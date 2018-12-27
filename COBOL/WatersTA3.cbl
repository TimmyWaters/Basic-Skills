*>****************************************************************
*> Author: Timothy Waters
*> Date: June 17, 2018
*> Troy University
*> CS 3320: Business Systems Programming
*> Purpose: This program records inventory items and generates an
*> output file containing the inventory items.
*>****************************************************************
IDENTIFICATION DIVISION.
PROGRAM-ID. WatersTA3.

ENVIRONMENT DIVISION.
INPUT-OUTPUT SECTION.
FILE-CONTROL.
    SELECT INVOUT
        ASSIGN TO "WatersTA3.rpt".

DATA DIVISION.

FILE SECTION.
FD INVOUT.
    01 OUT-INV-RECORD.
        05 PART-NO      PIC X(5).
        05 PART-DESC    PIC X(15).
        05 VENDOR-CODE  PIC X(4).
        05 VENDOR-DESC  PIC X(20).
        05 QTY-ON-HAND  PIC 9(5).
        05 UNIT-PRICE   PIC 9(5).99.

WORKING-STORAGE SECTION.
01 WS-WORK-AREAS.
          05 MORE-RECORDS              PIC X(1) VALUE "Y".

PROCEDURE DIVISION.
100-MAIN-PROCEDURE.
    OPEN OUTPUT INVOUT

    PERFORM UNTIL MORE-RECORDS = "N"
        DISPLAY "ENTER PART NUMBER:"
        ACCEPT PART-NO
        DISPLAY "ENTER PART DESCRIPTION:"
        ACCEPT PART-DESC
        DISPLAY "ENTER VENDOR CODE:"
        ACCEPT VENDOR-CODE
        DISPLAY "ENTER VENDOR DESCRIPTION:"
        ACCEPT VENDOR-DESC
        DISPLAY "ENTER QUANTITY ON-HAND:"
        ACCEPT QTY-ON-HAND
        DISPLAY "ENTER UNIT PRICE:"
        ACCEPT UNIT-PRICE
        DISPLAY "IS THERE MORE DATA? (Y/N)"
        ACCEPT MORE-RECORDS
        WRITE OUT-INV-RECORD
    END-PERFORM
    CLOSE INVOUT

    DISPLAY "Hello world"
    STOP RUN.

END PROGRAM WatersTA3.
