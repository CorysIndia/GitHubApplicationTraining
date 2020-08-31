; Script generated with the Venis Install Wizard
!include "FileAssociation.nsh"
;!include "FileFunc.nsh"

; Define your application name
!define APPNAME "UGP_STG"
!define APPNAMEANDVERSION "UGP_STG"
!define VERSION "1.0"
!define PUBLISHER "RSI"


; Main Install settings
Name "${APPNAME} ${VERSION}"
InstallDir "$LOCALAPPDATA\RSI\${APPNAME} ${VERSION}"
InstallDirRegKey HKLM "Software\${APPNAME} ${VERSION}" ""

!define /date MyTIMESTAMP "%d%m%Y_%H%M%S"
 
OutFile "..\${APPNAME}_${VERSION}_${MyTIMESTAMP}.exe"
RequestExecutionLevel admin ;Require admin rights on NT6+ (When UAC is turned on)

; Modern interface settings
!include "MUI.nsh"

!define MUI_ABORTWARNING

!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_DIRECTORY
;!insertmacro MUI_PAGE_COMPONENTS
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_PAGE_FINISH

!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES

; Set languages (first is default language)
!insertmacro MUI_LANGUAGE "English"
!insertmacro MUI_RESERVEFILE_LANGDLL

;section obligatoire d'ou le -
Section "UGP_STG" Section1
SetShellVarContext current

	; Set Section properties
	SetOverwrite on

	; -------------------------------------------------------------------------------------------------------------------
	; UGP_STG
	; -------------------------------------------------------------------------------------------------------------------
	SetOutPath "$INSTDIR"
	File /r /x "*.pdb" "..\bin\Release\*.*"
	
	; -------------------------------------------------------------------------------------------------------------------
	; ShortCuts
	; -------------------------------------------------------------------------------------------------------------------
	CreateShortCut "$DESKTOP\${APPNAMEANDVERSION}.lnk" \ 
				   "$INSTDIR\UGP_STG.Exe"	


Return

SectionEnd

Section -FinishSection
SetShellVarContext all
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME} ${VERSION}" "DisplayName" "${APPNAME}"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME} ${VERSION}" "UninstallString" "$INSTDIR\uninstall.exe"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME} ${VERSION}" "Publisher" "${PUBLISHER}"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME} ${VERSION}" "DisplayVersion" "${VERSION}"
	WriteUninstaller "$INSTDIR\uninstall.exe"
	${RegisterExtension} "C:\Program Files (x86)\RSI\Viewer 2.3.0\Viewer.exe" ".V23" "Viewer_File_V23"

SectionEnd


;Uninstall section
Section Uninstall
	SetShellVarContext all

	;Remove from registry...
	DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME} ${VERSION}"
	DeleteRegKey HKLM "SOFTWARE\${APPNAME} ${VERSION}"
	DeleteRegKey /ifempty HKLM "SOFTWARE\${APPNAME}"
	
	
	; Delete self
	Delete "$INSTDIR\uninstall.exe"

	; Delete Shortcuts
	Delete "$DESKTOP\${APPNAMEANDVERSION}.lnk"
	; Clean up Core
	RMDir /r $INSTDIR

SectionEnd

BrandingText "Copyright 2010-2012 RSI"


; eof