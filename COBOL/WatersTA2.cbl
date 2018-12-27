      *>*****************************************************************
      *> Author: Timothy Waters
      *> Date: June 9, 2018
      *> Troy University
      *> CS 3320: Business Systems Programming (COBOL)
      *> Purpose: This batch program sorts students that have not
      *> registered in the last two terms.
      *>*****************************************************************
       IDENTIFICATION DIVISION.
       PROGRAM-ID. WatersTA2.

       ENVIRONMENT DIVISION.
       INPUT-OUTPUT SECTION.
       FILE-CONTROL.
           SELECT REGISTRATION-MASTER
               ASSIGN TO 'REGISTRATIONS.DAT'
               ORGANIZATION IS LINE SEQUENTIAL.

           SELECT REMINDER-NOTICES
               ASSIGN TO 'WatersTA2.RPT'
               ORGANIZATION IS LINE SEQUENTIAL.

       DATA DIVISION.
       FILE SECTION.
       FD REGISTRATION-MASTER.
       01 IN-STUDENT-REC.
          05 IN-STUDENT-ID             PIC X(9).
          05 IN-STUDENT-NAME.
             10 IN-FIRST-NAME          PIC X(15).
             10 IN-MIDDLE-INIT         PIC X(1).
             10 IN-LAST-NAME           PIC X(15).
          05 DATE-OF-BIRTH.
             10 DOB-YEAR               PIC 9(4).
             10 DOB-MONTH              PIC 9(2).
             10 DOB-DAY                PIC 9(2).
          05 IN-MAILING-ADDRESS.
             10 IN-ADDRESS1            PIC X(20).
             10 IN-ADDRESS1            PIC X(20).
             10 IN-CITY                PIC X(15).
             10 IN-STATE               PIC X(2).
             10 IN-ZIP                 PIC X(9).
          05 IN-ACADEMID-PROGRAM       PIC X(20).
          05 IN-ACADEMID-LEVEL         PIC X(20).
          05 IN-CLASS                  PIC X(10).
          05 IN-CREDITS-COMPLETED      PIC X(10).
          05 IN-DATE-LAST-ENROLLMENT.
             10 LAST-ENROLLED-YEAR     PIC 9(4).
             10 LAST-ENROLLED-MONTH    PIC 9(2).
             10 LAST-ENROLLED-DAY      PIC 9(2).
          05 SEND-NOTICE               PIC X(1).

       FD REMINDER-NOTICES.
       01 OUT-REMINDER-REC.
          05 OUT-STUDENT-ID             PIC X(9).
          05 OUT-STUDENT-NAME.
             10 OUT-FIRST-NAME          PIC X(15).
             10 OUT-MIDDLE-INIT         PIC X(1).
             10 OUT-LAST-NAME           PIC X(15).
          05 OUT-MAILING-ADDRESS.
             10 OUT-ADDRESS1            PIC X(20).
             10 OUT-ADDRESS1            PIC X(20).
             10 OUT-CITY                PIC X(15).
             10 OUT-STATE               PIC X(2).
             10 OUT-ZIP                 PIC X(9).
          05 OUT-DATE-LAST-ENROLLMENT.
             10 LAST-ENROLLED-YEAR      PIC 9(4).
             10 LAST-ENROLLED-MONTH     PIC 9(2).
             10 LAST-ENROLLED-DAY       PIC 9(2).

       WORKING-STORAGE SECTION.
       01 WS-WORK-AREAS.
          05 MORE-RECORDS              PIC X(1) VALUE "Y".

       PROCEDURE DIVISION.
      *>  100-main-module- controls opening and closing files and
      *>  direction of the program logic; returns control to the
      *>  operating system.
       100-MAIN-MODULE.
           OPEN INPUT REGISTRATION-MASTER
                OUTPUT REMINDER-NOTICES

           PERFORM UNTIL MORE-RECORDS = "N"
               READ REGISTRATION-MASTER
                   AT END
                        MOVE "N" TO MORE-RECORDS
                   NOT AT END
                       PERFORM 200-PROCESS-RENEWAL
               END-READ
           END-PERFORM
               CLOSE REGISTRATION-MASTER
                     REMINDER-NOTICES
           STOP RUN.

      *>  200-process-renewal - performed from 100-main-module
      *>  checks the value of the field send-notice and when it is "Y"
      *>  moves that license record to renewal and writes the record.
       200-PROCESS-RENEWAL.
           IF SEND-NOTICE = "Y"
               MOVE IN-STUDENT-ID TO OUT-STUDENT-ID
               MOVE IN-STUDENT-NAME TO OUT-STUDENT-NAME
               MOVE IN-MAILING-ADDRESS TO OUT-MAILING-ADDRESS
               MOVE IN-DATE-LAST-ENROLLMENT TO OUT-DATE-LAST-ENROLLMENT
               WRITE OUT-REMINDER-REC
           END-IF.
       END PROGRAM WatersTA2.
