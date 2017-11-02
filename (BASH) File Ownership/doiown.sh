#!/bin/bash

err_fn () {
	echo $1
	echo $2
	exit 10
}

echo Please enter the name of a file:

read userinput

if [ -O $userinput  ]
	then
		echo The file is there and you own it.
	elif [ -e $userinput ]
		then
			err_fn "The file was found, but you do not own it. Please try again." "You entered $userinput."
	else
		err_fn "The file was not found, please try again." "You entered $userinput"
fi
