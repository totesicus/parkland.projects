#!/bin/bash

err_fn () {
	echo $1
	echo $2
	exit 10
}

if [ -O $1  ]
	then
		echo The file is there and you own it.
	elif [ -e $1 ]
		then
			err_fn "The file was found, but you do not own it. Please try again." "You entered $1."
	else
		err_fn "The file was not found, please try again." "You entered $1"
fi
