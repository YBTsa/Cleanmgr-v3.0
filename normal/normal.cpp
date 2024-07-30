#include <iostream>
#include <windows.h>
using namespace std;
int main() {
    system("title normal");
    
    system("del /f /s /q C:\\*.tmp");
    system("del /f /s /q C:\\*._mp");
    system("del /f /s /q C:\\*.gid");
    system("del /f /s /q C:\\*.chk");
    system("del /f /s /q C:\\*.old");
    system("del /f /s /q %windir%\\*.bak");
    system("del /f /s /q %windir%\\temp\\*.*");
    system("del /f /s /q %windir%\\SoftwareDistribution\\Download\\*.* ");
    system("del /f /s /q %userprofile%\\cookies\\*.*");
    system("del /f /s /q %userprofile%\\recent\\*.*");
    system("del /f /s /q %userprofile%\\local settings\\temporary internet files\\*.*");
    system("del /f /s /q %userprofile%\\local settings\\temp\\*.*");
    system("Dism.exe /online /Cleanup-Image /StartComponentCleanup /ResetBase");
    system("taskkill /f /im explorer.exe");
    system("start explorer.exe");
    return 0;
}