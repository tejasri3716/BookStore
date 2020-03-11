#!/bin/bash
read -p "Enter any key to start time: " begin
start=$(date +%s)
echo "start time in milli seconds is $start"
read -p "enter any key to end time: " end
end=$(date +%s)
echo "end time in milliseconds is $end"
echo  "$(date -u --date @$(( $end - $start )) +%H:%M:%S)"
