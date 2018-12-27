#!/bin/bash
array=(Encryption EncryptProg)
echo "Compiling Program 5:"
for item in ${array[*]}
do
    echo "Compiling: $item"
    javac $item.java
done
