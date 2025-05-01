
; You may customize this and other start-up templates; 
; The location of this template is c:\emu8086\inc\0_com_template.txt

include emu8086.inc
 ORG    100h
 PRINT 'Hello World!'
 GOTOXY 10, 5
 PUTC 65          
 PUTC 'B'
 RET




