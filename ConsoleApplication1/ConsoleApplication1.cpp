#include <iostream>
#include <windows.h>
#include <psapi.h>
#include <iomanip>
#include <string>

int main() {
    // Konsol başlığı
    SetConsoleTitleA("THE LIST OF ACTIVE PROCESSES");

    // Tablo Başlıkları
    std::cout << std::left
        << std::setw(8) << "PID"
        << std::setw(35) << "PROCESS NAME"
        << std::setw(10) << "MOD"
        << std::setw(10) << "VER."
        << "CPU" << std::endl;

    std::cout << "----------------------------------------------------------------------\n";

    DWORD aProcesses[1024], cbNeeded, cProcesses;

    // 1. Sistemdeki tüm aktif süreçlerin PID'lerini (Process ID) topla
    if (EnumProcesses(aProcesses, sizeof(aProcesses), &cbNeeded)) {

        // Kaç tane süreç yakaladığımızı hesapla
        cProcesses = cbNeeded / sizeof(DWORD);

        for (unsigned int i = 0; i < cProcesses; i++) {
            if (aProcesses[i] != 0) {
                DWORD processID = aProcesses[i];

                // 2. İlgili sürece bağlanmak ve bilgi okumak için Handle (izin) al
                HANDLE hProcess = OpenProcess(PROCESS_QUERY_INFORMATION | PROCESS_VM_READ, FALSE, processID);

                if (hProcess != NULL) {
                    char szProcessName[MAX_PATH] = "<unknown>";
                    HMODULE hMod;
                    DWORD cbNeededMod;

                    // 3. Sürecin adını (örneğin: svchost.exe) çek
                    if (EnumProcessModules(hProcess, &hMod, sizeof(hMod), &cbNeededMod)) {
                        GetModuleBaseNameA(hProcess, hMod, szProcessName, sizeof(szProcessName) / sizeof(char));
                    }

                    // 4. Mimarisi Native (64-bit) mi yoksa WoW64 (32-bit) mi kontrol et
                    BOOL isWow64 = FALSE;
                    IsWow64Process(hProcess, &isWow64);
                    const char* modType = isWow64 ? "WoW64" : "Native";

                    // 5. Sürecin sürüm (version) bilgisini al ve Major.Minor formatına çevir
                    DWORD version = GetProcessVersion(processID);
                    DWORD major = HIWORD(version);
                    DWORD minor = LOWORD(version);

                    // 6. Mevcut işlemcinin çekirdek numarasını al
                    DWORD cpuNumber = GetCurrentProcessorNumber();

                    // Sadece adı okunabilen süreçleri tabloya yazdır (<unknown> olanları gizle)
                    if (std::string(szProcessName) != "<unknown>") {
                        std::cout << std::left
                            << std::setw(8) << processID
                            << std::setw(35) << szProcessName
                            << std::setw(10) << modType
                            << major << "." << std::setw(8) << minor
                            << cpuNumber << std::endl;
                    }

                    // İşletim sisteminde kaynak sızıntısı olmaması için handle'ı kapat
                    CloseHandle(hProcess);
                }
            }
        }
    }

    std::cout << "\nIslem tamamlandi. Cikmak icin Enter'a basin...";
    std::cin.get();
    return 0;
}