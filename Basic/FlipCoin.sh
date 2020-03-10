echo "number of flips"
read n
hc=0
tc=0
for((i=0;i<$n;i++))
do
random=$((0+$RANDOM%11))
if(($random < 5))
then
hc=$(($hc+1))
else
tc=$(($tc+1))
fi
done
headcount=$(((($hc*100))/$n))
tailcount=$(((($tc*100))/$n))
echo "Percentage of heads is $headcount%"
echo "Percentage of Tails is $tailcount%"

