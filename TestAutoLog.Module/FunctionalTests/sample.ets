;#DropDB TestAutoLogEasyTest

#Application TestAutoLogWin
#Application TestAutoLogWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef TestAutoLogWin

*Action About...
 
*Action OK

#EndIf

#IfDef TestAutoLogWeb
*Action Navigation(My Details)
#EndIf
