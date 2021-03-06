; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "mtsToolsConsole"
#define MyAppVersion "0.0.0.1"
#define MyAppPublisher "ITECH ELECTRONIC CO.,LTD."
#define MyAppURL "http://www.itech.sh/"
#define MyAppExeName "mtsToolsConsole.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{54687B35-B4B8-461B-BC9D-CDA39745688A}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DisableProgramGroupPage=yes
LicenseFile=F:\document_repository\publich_library\The MIT License.txt
OutputDir=F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish
OutputBaseFilename=mtsToolsConsole_Setup
SetupIconFile=F:\document_repository\publich_library\install.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\mtsToolsConsole.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.Charts.v19.1.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.Data.v19.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.Data.v19.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.Images.v19.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.Office.v19.1.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.Office.v19.1.Core.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.Pdf.v19.1.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.Pdf.v19.1.Core.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.Printing.v19.1.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.Printing.v19.1.Core.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.RichEdit.v19.1.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.RichEdit.v19.1.Core.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.Sparkline.v19.1.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.Sparkline.v19.1.Core.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.Utils.v19.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.Utils.v19.1.UI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.Utils.v19.1.UI.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.Utils.v19.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraBars.v19.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraBars.v19.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraCharts.v19.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraCharts.v19.1.UI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraCharts.v19.1.UI.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraCharts.v19.1.Wizard.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraCharts.v19.1.Wizard.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraCharts.v19.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraEditors.v19.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraEditors.v19.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraGrid.v19.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraGrid.v19.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraLayout.v19.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraLayout.v19.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraNavBar.v19.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraNavBar.v19.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraPrinting.v19.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraPrinting.v19.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraRichEdit.v19.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraRichEdit.v19.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraTreeList.v19.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraTreeList.v19.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraVerticalGrid.v19.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\DevExpress.XtraVerticalGrid.v19.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\mtsToolsConsole.Common.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\mtsToolsConsole.Common.dll.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\mtsToolsConsole.Common.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\mtsToolsConsole.Controller.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\mtsToolsConsole.Controller.dll.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\mtsToolsConsole.Controller.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\mtsToolsConsole.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\mtsToolsConsole.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\mtsToolsConsole.Model.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\mtsToolsConsole.Model.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\mtsToolsConsole.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\mtsToolsConsole.Repository.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\mtsToolsConsole.Repository.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\mtsToolsConsole.StaticSource.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\mtsToolsConsole.StaticSource.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\Newtonsoft.Json.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\System.Net.Http.Formatting.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\System.Net.Http.Formatting.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\de\*"; DestDir: "{app}\"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\es\*"; DestDir: "{app}\"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\ja\*"; DestDir: "{app}\"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "F:\svn_repository\mts_Related\mtsToolsConsole\mtsToolsConsole.Publish\mtsToolsConsole\ru\*"; DestDir: "{app}\"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

