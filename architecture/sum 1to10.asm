
; You may customize this and other start-up templates; 
; The location of this template is c:\emu8086\inc\0_com_template.txt

include emu8086.inc     
mov  ax, 1   
mov cx, 10   
xor dx, dx      
Label1: 
add  dx, ax      
inc  ax   
loop Label1
mov ax,dx  
CALL PRINT_NUM 
RET                          
DEFINE_PRINT_NUM 
DEFINE_PRINT_NUM_UNS 
END


