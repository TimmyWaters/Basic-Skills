*>****************************************************************
*> Author: Timothy Waters
*> Date: June 23, 2018
*> Troy University
*> CS 3320: Business Systems Programming
*> Purpose: This program determines whether a date entered by
*> the user is 40 years old or not.
*>****************************************************************
       IDENTIFICATION DIVISION.
       PROGRAM-ID. WatersTA4.
       DATA DIVISION.
       WORKING-STORAGE SECTION.
       01  DOB-IN  PIC X(10).
       01  DOB-WS.
           05  YR-WS   PIC 9(4).
           05  MO-WS   PIC 9(2).
           05  DAY-WS  PIC 9(2).
       01  TODAY.
           05  TODAY-YR   PIC 9(4).
           05  TODAY-MO   PIC 9(2).
           05  TODAY-DAY  PIC 9(2).
       01  CUTOFF-DATE.
           05  CUTOFF-YR   PIC 9(4).
           05  CUTOFF-MO   PIC 9(2).
           05  CUTOFF-DAY  PIC 9(2).
       01  CUTOFF-DOB  PIC 9(8).
       01  NAME-IN  PIC X(40).
       01  GOOD-MSG  PIC X(40) VALUE " QUALIFIES FOR ADEA PROTECTION.".
       01  BAD-MSG  PIC X(40) VALUE " DOES NOT QUALIFY FOR ADEA PROTECTION.".
       01  OUT-MSG  PIC X(50).
       01  MORE-DATA   PIC X VALUE "Y".
       PROCEDURE DIVISION.
       100-MAIN.
           PERFORM UNTIL MORE-DATA = "N"
               PERFORM 200-DISPLAY-SCREEN
               PERFORM 300-PROCESS-DOB
               PERFORM 400-CHECK-AGE
               PERFORM 500-ASK-MORE-DATA
           END-PERFORM
           STOP RUN.
       200-DISPLAY-SCREEN.
           DISPLAY "ENTER DATE OF BIRTH (MM/DD/YYYY):"
               AT LINE 2
                   COLUMN 5
               WITH BLANK SCREEN
               FOREGROUND-COLOR 1
               BACKGROUND-COLOR 7
           ACCEPT DOB-IN
               AT LINE 2
                   COLUMN 40.
          DISPLAY "ENTER NAME:"
               AT LINE 4
                   COLUMN 5
               WITH BLANK SCREEN
               FOREGROUND-COLOR 1
               BACKGROUND-COLOR 7
           ACCEPT NAME-IN
               AT LINE 4
                   COLUMN 17.
       300-PROCESS-DOB.
           UNSTRING DOB-IN DELIMITED BY "/" OR "."
               INTO MO-WS
                   DAY-WS
                   YR-WS.
       400-CHECK-AGE.
           MOVE FUNCTION CURRENT-DATE TO TODAY
           SUBTRACT 40 FROM TODAY-YR GIVING CUTOFF-YR
           MOVE TODAY-MO TO CUTOFF-MO
           MOVE TODAY-DAY TO CUTOFF-DAY
           MOVE CUTOFF-DATE TO CUTOFF-DOB
           IF DOB-WS <= CUTOFF-DOB
               STRING
                 NAME-IN DELIMITED BY " ",
                 GOOD-MSG DELIMITED BY SIZE
                 INTO OUT-MSG
               DISPLAY OUT-MSG
                   AT LINE 6
                       COLUMN 5 WITH
                       FOREGROUND-COLOR 1
                       BACKGROUND-COLOR 7
           ELSE
               STRING
                 NAME-IN DELIMITED BY " ",
                 BAD-MSG DELIMITED BY SIZE
                 INTO OUT-MSG
               DISPLAY OUT-MSG
                   AT LINE 6
                       COLUMN 5 WITH REVERSE-VIDEO
                       FOREGROUND-COLOR 4
                       BACKGROUND-COLOR 7
           END-IF.
       500-ASK-MORE-DATA.
               DISPLAY "IS THERE MORE DATA (Y/N)?"
                   AT LINE 8
                       COLUMN 5 WITH
                       FOREGROUND-COLOR 1
                       BACKGROUND-COLOR 7
               ACCEPT MORE-DATA
                   AT LINE 8
                       COLUMN 32
                       WITH REVERSE-VIDEO.
       END PROGRAM WatersTA4.
