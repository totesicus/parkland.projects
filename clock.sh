#!/bin/bash

Color1=$(tput setaf 1)
Color2=$`tput setaf 4`
Normal=$`tput sgr0`

while true
do
	Columns=$(tput cols)
	Startpoint=$(($Columns-23))

	tput sc
	tput cup 0 $Startpoint
	Time=$(date +"%r")
	Date=$(date +"%d-%m-%Y")
	echo -n $Color1 $Time $Color2 $Date $Normal
	tput rc
	sleep 1
done


