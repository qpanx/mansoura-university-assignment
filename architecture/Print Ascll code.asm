
org 100h


MOV AH , 2
MOV CX , 256
MOV DL , 0
Print_Loop:
INT 21h
INC DL
DEC CX
JNZ Print_Loop
END






