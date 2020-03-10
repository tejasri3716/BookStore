echo "enter a number to print two table"
read number
if (( $number>0 && $number<31))
then
for ((i=0;i<=$number;i++))
do
power=`expr 2 \* $i`
echo "2^" $i" =" $power
done
else
echo "invalid input"
fi
