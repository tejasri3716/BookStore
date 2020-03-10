#!/bin/sh 
# Program to check whether it is leap year or not
echo "Enter year to check whether it is leap year or not"
read year
if (($(($year%4 == 0)) && $(($year%100 != 0)) || $(($year%400 == 0))))
then
echo "$year is a Leap Year"
else
echo "$year is not a Leap Year"
fi
