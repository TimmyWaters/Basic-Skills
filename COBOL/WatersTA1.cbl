*>****************************************************************
*> Author: Timothy Waters
*> Date: June 3, 2018
*> Troy University
*> CS 3320: Business Systems Programming
*> Purpose: This program accepts a salary input and calculates
*> and displays income tax as 20 percent of the salary.
*>****************************************************************
       IDENTIFICATION DIVISION.
       PROGRAM-ID. WatersTA1.
       DATA DIVISION.
       WORKING-STORAGE SECTION.
       01  SALARY       PICTURE 999999.
       01  INCOME-TAX        PICTURE 99999.99.
       01  MORE-DATA   PICTURE XXX VALUE "YES".
       PROCEDURE DIVISION.
       100-MAIN.
           PERFORM UNTIL MORE-DATA = "NO "
               DISPLAY "ENTER SALARY AS AN INTEGER FIELD"
               ACCEPT SALARY
               MULTIPLY SALARY BY .20 GIVING INCOME-TAX
               DISPLAY "THE INCOME TAX IS  ", INCOME-TAX
               DISPLAY "IS THERE MORE DATA (YES/NO)?"
               ACCEPT MORE-DATA
          END-PERFORM
          STOP RUN.
       END PROGRAM WatersTA1.
