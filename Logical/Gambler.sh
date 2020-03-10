#!/bin/bash -x
echo "enter stake value :"
read stake
echo "enter goal value :"
read goal
echo "enter number of trials :"
read trials
bets=0
wins=0
loss=0
cash=$stake
for (( t=1; t<=$trials; t++ ))
do
	while [[ $cash > 0 && $cash < $goal ]]
	do
	bets=$(($bets + 1 ))
	random=$(($RANDOM % 2))
	if [[ $random -eq 0 ]]
	#if [[ $cash -le 100 ]]
        then
        cash=$(( $cash + 1 ))
	wins=$(( $wins + 1 ))
        else
       cash=$(( $cash - 1 ))
	loss=$(( $loss + 1 ))
        fi
	if (( $cash >= $goal ))
	then
	break;
	else
	break;
	 fi
	done
done
echo $wins "wins of" $trials
echo "win percentage is =" $(($((100*$wins))/$trials))
echo "loss percentage is =" $(($((100*$loss))/$trials))
