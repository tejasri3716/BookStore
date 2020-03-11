echo "enter the coupon"
read n
c=""
s=" "
for (( i=0; i<=$n; i++ ))
do
rand=$(( RANDOM ))
if [ $c1!=$rand ]
then
	c=$c$rand$s
else
	i=$(($i-1))
fi
done
echo $c

