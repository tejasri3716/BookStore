echo -n "enter the size of an array"
read n
declare -a array[$n]
for (( i=0;i<$n;i++ ))
do
read array[$i]
done
for (( i=0;i<$n-2;i++ ))
do
for (( j=i+1;i<$n-1;j++ ))
do
for (( k=j+1;k<$n;k++ ))
do
sum=$(( array[$i] + array[$j] + array[$k] ))
if [ $sum -eq 0 ]
then
echo "${array[$i]} ${array[$j]} ${array[$k]}"
fi
done
done
done
