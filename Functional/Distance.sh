echo -n "enter x value"
read x1
echo -n "enter y value"
read y1
a=`expr $x1 \* $x1`
b=`expr $y1 \* $y1`
dist=`expr $a + $b`
distance=`echo - | awk '{print sqrt('$dist')}'`
echo $distance
