*>****************************************************************
*> Author: Timothy Waters
*> Date: July 7, 2018
*> Troy University
*> CS 3320: Business Systems Programming
*> Purpose: This program calculates the required down-payment
*> for a mortage.
*>****************************************************************
IDENTIFICATION DIVISION.
PROGRAM-ID. WatersTA6.
DATA DIVISION.
FILE SECTION.
WORKING-STORAGE SECTION.
01 WS-WORK-AREAS.
    05 MORE-RECORDS              PIC X(1) VALUE "Y".

01 AMOUNTS.
    05 BORROW-AMT       PIC 9(10).
    05 HOUSE-AMT        PIC 9(10).
    05 HOUSE-HALF       PIC 9(10).
    05 BORROW-PAY    PIC 9(10).
    05 HOLD-AMT-60         PIC 9(10).
    05 HOLD-AMT-30         PIC 9(10).
    05 HOLD-AMT-MORE         PIC 9(10).
    05 HOLD-AMT-LAST         PIC 9(10).

01 OUTPUT-AMOUNTS.
    05 OUT-BORROW-PAY    PIC $(6).
    05 OUT-HOLD-AMT-60         PIC Z(10).
    05 OUT-HOLD-AMT-30         PIC Z(10).
    05 OUT-HOLD-AMT-MORE         PIC Z(10).
    05 OUT-HOLD-AMT-LAST         PIC Z(10).

PROCEDURE DIVISION.
100-MAIN-PROCEDURE.
    PERFORM UNTIL MORE-RECORDS = "N" OR "n"
        DISPLAY "ENTER AMOUNT TO BORROW:"
        ACCEPT BORROW-AMT
        DISPLAY "ENTER AMOUNT OF HOUSE:"
        ACCEPT HOUSE-AMT

        IF HOUSE-AMT > 500000
            DISPLAY "THE PRICE OF THE HOUSE IS TOO HIGH"
        ELSE
            DISPLAY "THE PRICE OF THE HOUSE IS OK!"
            MULTIPLY HOUSE-AMT BY .5 GIVING HOUSE-HALF
            IF BORROW-AMT <= HOUSE-HALF
                DISPLAY "THE AMOUNT TO BORROW IS OK!"
                PERFORM 200-DOWN-PAYMENT
                MOVE BORROW-PAY TO OUT-BORROW-PAY
                DISPLAY "THE DOWN PAYMENT AMOUNT IS:"
                DISPLAY OUT-BORROW-PAY
            ELSE
                DISPLAY "THE AMOUNT TO BORROW IS NOT OK!"
            END-IF
        END-IF

        DISPLAY "IS THERE MORE DATA? (Y/N)"
        ACCEPT MORE-RECORDS
    END-PERFORM
    STOP RUN.


200-DOWN-PAYMENT.
    IF BORROW-AMT <= 60000
        MULTIPLY BORROW-AMT BY .1 GIVING BORROW-PAY
        DISPLAY BORROW-PAY
    ELSE
        IF BORROW-AMT > 60000
            SUBTRACT 60000 FROM BORROW-AMT GIVING HOLD-AMT-60
            MULTIPLY 60000 BY .1 GIVING BORROW-PAY

            IF HOLD-AMT-60 <= 30000
                MULTIPLY HOLD-AMT-60 BY .075 GIVING HOLD-AMT-30
                ADD HOLD-AMT-30 TO BORROW-PAY
            ELSE
                SUBTRACT 30000 FROM HOLD-AMT-60 GIVING HOLD-AMT-MORE
                MULTIPLY 30000 BY .075 GIVING HOLD-AMT-30
                ADD HOLD-AMT-30 TO BORROW-PAY
                MULTIPLY HOLD-AMT-MORE BY .05 GIVING HOLD-AMT-LAST
                ADD HOLD-AMT-LAST TO BORROW-PAY
            END-IF
        END-IF
    END-IF.

END PROGRAM WatersTA6.
