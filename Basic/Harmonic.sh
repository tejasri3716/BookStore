echo "enter the number"
read number
sum=0
for ((i=1;i<=$number;i++))
do
sum=$(echo "$i" "$sum" |awk '{print $2 + (1/$1)}')
done
echo "$number harmonic number is  $sum"
