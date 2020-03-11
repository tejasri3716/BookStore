echo "hello <<username>>,How are you?"
read username
if [ ${#username} -ge '3' ]
then
echo "Hello $username , How are you?"
else
echo "invalid input"
fi
