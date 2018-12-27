#!/bin/bash
array=(Date Employee CommissionEmployee BasePlusCommissionEmployee HourlyEmployee SalariedEmployee PayrollSystemTest)
echo "Compiling Program 4:"
for item in ${array[*]}
do
    echo "Compiling: $item"
    javac $item.java
done