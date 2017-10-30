#!/bin/bash
	
	Hostname=$(echo $1)
	Port=$(echo $2)
	Message=$(echo $@ | cut -d " " -f 3-900 | nc -w 1 $Hostname $Port)
	
	echo $Message
