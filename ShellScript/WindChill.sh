echo -n "enter temp "
read temperature
echo -n "enter wind speed "
read windSpeed
if [ $temperature -le 50 ]
then
if [ $windSpeed -le 120 -a $windSpeed -ge 3 ]
then
windChill=$(echo "$temperatur" "$windSpeed" | awk '{print (35.74+0.6215*$1)-(0.275*$1-35.75)*($2^0.16)}')
echo "Wind Chill $windChill"
else
echo "invalid input"
fi
fi
