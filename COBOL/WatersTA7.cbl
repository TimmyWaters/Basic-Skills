*>****************************************************************
*> Author: Timothy Waters
*> Date: July 12, 2018
*> Troy University
*> CS 3320: Business Systems Programming
*> Purpose: This program generates input from the user
*> as many times as the user requests.
*>****************************************************************
IDENTIFICATION DIVISION.
PROGRAM-ID. WatersTA7.
DATA DIVISION.
FILE SECTION.
WORKING-STORAGE SECTION.
01 COUNTER      PIC 999.
01 COUNTER-INPUT PIC 999.
01 COUNTER-DISP  PIC Z(3).
01 PHRASE       PIC X(50).
01 MOD-NUM      PIC 99.
01 QUOTIENT     PIC 99.
01 SHOW-MORE    PIC X.

PROCEDURE DIVISION.
MAIN-PROCEDURE.
    *> DISPLAY "Hello world"
    DISPLAY "ENTER YOUR PHRASE:"
    ACCEPT PHRASE
    DISPLAY "HOW MANY TIMES?"
    ACCEPT COUNTER-INPUT
    MOVE 1 TO COUNTER
    PERFORM UNTIL COUNTER > COUNTER-INPUT
        MOVE COUNTER TO COUNTER-DISP
        DISPLAY COUNTER-DISP ". " PHRASE
        DIVIDE COUNTER BY 20 GIVING QUOTIENT REMAINDER MOD-NUM
        IF MOD-NUM = 0 AND COUNTER < COUNTER-INPUT
            DISPLAY "HIT ENTER TO CONTINUE:"
            ACCEPT SHOW-MORE
        END-IF
        ADD 1 TO COUNTER
    END-PERFORM
    STOP RUN.
END PROGRAM WatersTA7.
