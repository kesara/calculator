;------------------------------------------------
;Calculator.NET
;Version 1.0.0.0
;Copyright (C) 2007 Kesara Nanayakkara Rathnayake
;------------------------------------------------

;--------------------------------
;Include

	!include "MUI.nsh"

;--------------------------------
;General

	;Name and file
	Name "Calculator.NET"
	BrandingText "Calculator.NET Version 1.0.0.0"
	OutFile "Calculator.NET-1.0.0.0-Setup.exe"

	;Default installation folder
	InstallDir "$PROGRAMFILES\Calculator.NET"
	
	;Get installation folder from registry if available
	InstallDirRegKey HKCU "Software\Calculator.NET" ""

;--------------------------------
;Functions

	Function .onInit
		Push $R0 
		ClearErrors
		ReadRegStr $R0 HKLM "SOFTWARE\Microsoft\NET Framework Setup\NDP\v3.5" "Version"
		IfErrors lbl_err lbl_end
		lbl_err:
		MessageBox MB_OK|MB_ICONSTOP ".NET runtime library v3.5 or newer is required."
		Abort

		lbl_end:
		Exch $0
	FunctionEnd

 
;--------------------------------
;Variables

	Var STARTMENU_FOLDER
	Var MUI_TEMP

;--------------------------------
;Interface Settings

	!define MUI_ABORTWARNING
	
	!define MUI_ICON "${NSISDIR}\Contrib\Graphics\Icons\orange-install.ico"
	!define MUI_UNICON "${NSISDIR}\Contrib\Graphics\Icons\orange-uninstall.ico"

	!define MUI_HEADERIMAGE
	!define MUI_HEADERIMAGE_BITMAP "${NSISDIR}\Contrib\Graphics\Header\orange.bmp"
	!define MUI_HEADERIMAGE_UNBITMAP "${NSISDIR}\Contrib\Graphics\Header\orange-uninstall.bmp"

	!define MUI_HEADER_TRANSPARENT_TEXT "Calculator.NET Version 1.0.0.0"

	!define MUI_WELCOMEFINISHPAGE_BITMAP "${NSISDIR}\Contrib\Graphics\Wizard\orange.bmp"
	!define MUI_UNWELCOMEFINISHPAGE_BITMAP "${NSISDIR}\Contrib\Graphics\Wizard\orange-uninstall.bmp"

	!define MUI_FINISHPAGE_LINK "Calculator.NET Read Me"
	!define MUI_FINISHPAGE_LINK_LOCATION "http://code.google.com/p/calculator/wiki/Readme"

	!define MUI_FINISHPAGE_RUN "$INSTDIR\Calculator.NET.exe"
	!define MUI_FINISHPAGE_RUN_TEXT "Run Calculator.NET now!"

;--------------------------------
;Pages

	!insertmacro MUI_PAGE_WELCOME
	!insertmacro MUI_PAGE_LICENSE "GPLv3.txt"
	;!insertmacro MUI_PAGE_COMPONENTS
	!insertmacro MUI_PAGE_DIRECTORY

	;Start Menu Folder Page Configuration
	!define MUI_STARTMENUPAGE_REGISTRY_ROOT "HKCU" 
	!define MUI_STARTMENUPAGE_REGISTRY_KEY "Software\Calculator.NET" 
	!define MUI_STARTMENUPAGE_REGISTRY_VALUENAME "Start Menu Folder"

	!insertmacro MUI_PAGE_STARTMENU Application $STARTMENU_FOLDER
	!insertmacro MUI_PAGE_INSTFILES
	!insertmacro MUI_UNPAGE_CONFIRM
	!insertmacro MUI_UNPAGE_INSTFILES
	!insertmacro MUI_PAGE_FINISH
	
;--------------------------------
;Languages
 
	!insertmacro MUI_LANGUAGE "English"

;--------------------------------
;Installer Sections

Section "Calculator" SecMain

	SetOutPath "$INSTDIR"
	
	;Files
	File "Calculator.NET.exe"
	
	;Store installation folder
	WriteRegStr HKCU "Software\Calculator.NET" "" $INSTDIR
	
	;Create uninstaller
	WriteUninstaller "$INSTDIR\Uninstall.exe"

	!insertmacro MUI_STARTMENU_WRITE_BEGIN Application
	  
	;Create shortcuts
	CreateDirectory "$SMPROGRAMS\$STARTMENU_FOLDER"
	CreateShortCut "$SMPROGRAMS\$STARTMENU_FOLDER\Calculator.NET.lnk" "$INSTDIR\Calculator.NET.exe"
	CreateShortCut "$SMPROGRAMS\$STARTMENU_FOLDER\Online Help.url" "http://code.google.com/p/calculator/wiki/OnlineHelp"
	CreateShortCut "$SMPROGRAMS\$STARTMENU_FOLDER\Uninstall.lnk" "$INSTDIR\Uninstall.exe"
	
	!insertmacro MUI_STARTMENU_WRITE_END

	;Adding to Windows Add or Remove Programs
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Calculator.NET" "DisplayName" "Calculator.NET Version 1.0.0.0"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Calculator.NET" "UninstallString" "$INSTDIR\uninstall.exe"

SectionEnd

;--------------------------------
;Descriptions

	;Language strings
	;LangString DESC_SecMain ${LANG_ENGLISH} "Calculator.NET"

	;Assign language strings to sections
	;!insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
	;!insertmacro MUI_DESCRIPTION_TEXT ${SecMain} $(DESC_SecMain)
	;!insertmacro MUI_FUNCTION_DESCRIPTION_END

;--------------------------------
;Uninstaller Section

Section "Uninstall"

	;Files
	Delete "$INSTDIR\Calculator.NET.exe"

	Delete "$INSTDIR\Uninstall.exe"

	RMDir "$INSTDIR"

	!insertmacro MUI_STARTMENU_GETFOLDER Application $MUI_TEMP

	Delete "$SMPROGRAMS\$MUI_TEMP\Uninstall.lnk"
	Delete "$SMPROGRAMS\$MUI_TEMP\Calculator.NET.lnk"
	Delete "$SMPROGRAMS\$MUI_TEMP\Online Help.url"


	;Delete empty start menu parent diretories
	StrCpy $MUI_TEMP "$SMPROGRAMS\$MUI_TEMP"
 
	startMenuDeleteLoop:
		ClearErrors
		RMDir $MUI_TEMP
		GetFullPathName $MUI_TEMP "$MUI_TEMP\.."
		IfErrors startMenuDeleteLoopDone
		StrCmp $MUI_TEMP $SMPROGRAMS startMenuDeleteLoopDone startMenuDeleteLoop
	startMenuDeleteLoopDone:
	

	DeleteRegKey /ifempty HKCU "Software\Calculator.NET"
	DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Calculator.NET"

SectionEnd
