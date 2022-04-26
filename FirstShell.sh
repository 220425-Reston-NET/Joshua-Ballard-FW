# This is a comment
echo "This is your first script!"

# Variables:
msg="Hello World Variable"
echo $msg #$Syntax needed to show a variable

#Control Flow
ten=10
five=5
thirteen=13

echo "===First If==="
if [ "$ten" -ge "$five" ]
then 
echo "Greater!"
echo "$ten > $five"
fi

echo "This is outside of the then fi"
echo "===Second If==="

if [ "$five" -ge "$ten" ]
then
echo "Greater!"
echo "$five > $ten"
elif [ "$five" -le "$ten" ]
then
echo "Lesser"
echo "$five < $ten"
fi

echo "===Third If==="
if [ "$five" -ge "$ten" ]
then
echo "Greater!"
echo "$five > $ten"
elif [ "$five" -ge "$thirteen" ]
then
echo "Greater!"
echo [ "$five" -le "$ten" ]
else
echo "Nothing Matches"
fi 

# Loop Statements:
# A way to repeat multiple lies of code x amount of times you want

# For Loops statement:
# Useful if you know how many times you need to execute those lines of code
echo "===For Loops"
echo "===First Loop==="
for number in 1 2 3 4 5
do
echo "Hello"
echo "$number"
done

echo "===Second Loop==="
for i in {1..10}
do
echo "$i"
done

echo "===While Loops==="
# While loop statement
# Useful if you don't know how many times you need to execute those lines of code

while [ "$five" -le "$ten" ]
do
echo "Lesser!"
five=$(($five+1)) # adds +1 to five variables
done

# Input and Output
# Ask for user input:
echo "What is your name?"
read  name # will get users input and store 

#Making a Shell Menu:

echo "Hello $name, welcome to programming!"
repeat="true"
while [ "$repeat" == "true" ]
do
echo "Welcome to shell scripting!"
echo "What do you want to do today?"
echo "Enter 1 for adding two numbers?"
echo "Enter 2 to exit"

read answer
if [ "$answer" == "1" ]
then
	echo "Give me number 1"
	read num1
	echo "Give me number 2"
	read num2
	echo "The sum is $(($num1+$num2))"
elif [ "$answer" == "2" ]
then
	repeate="false" 
else
	echo "Please enter correct answer"
fi
done