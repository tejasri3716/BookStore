echo  "enter number of rows :"
read m
echo  "enter number of columns :"
read n
echo  "enter array elements"
declare -A array
for (( i=1; i<=$m; i++ ))
do
for (( j=1; j<=$n; j++ ))
do
	read array[$i,$j]
done
done
	echo "array elements are"
for (( i=1; i<=$m; i++ ))
do
for (( j=1; j<=$n; j++ ))
do
	echo -e ${array[$i,$j]} '\c'
done
echo
done

