"use strict"

function convertFromToBase(){
	wiku()
	let buff = parseInt(document.getElementById('inNum').value, document.getElementById('oBase').value)
	document.getElementById('outNum').value = buff.toString(document.getElementById('tBase').value)
}

function decode(){
	wiku()
	let error = false
	let code = document.getElementById('inCode').value;
	let cheatSheet = {
		"01001":"A",
		"10":"F",
		"01000":"I",
		"0111":"M",
		"0101":"N",
		"11":"O",
		"0110":"R",
		"00":"T"
	}
	let length = 2
	let output = ""

	do{
		for(let letter in cheatSheet){
			if(code.substring(0, length) === letter){
				code = code.substring(length, code.length)
				output += cheatSheet[letter]
				length = 1
				break;
			}
		}
		length += 1
		if(length > 6){
			error = true
			break
		}
	}while(code.length > 0)
	if(!error)
		document.getElementById('outString').value = output
	else
		document.getElementById('outString').value = "ERROR"
}

function analyze(){
	wiku()
	let string = document.getElementById('text').innerHTML
	let counter = {}
	let percent
	let output = ""
	let entropy = 0
	for (let i=0; i<string.length; i+=1){
		if(!(string[i] in counter))
			counter[string[i]]=1
		else
			counter[string[i]]=counter[string[i]]+1
	}
	for (let value in counter){
		percent = (counter[value] / string.length * 100)
		entropy += (percent/100) * Math.log(1/(percent/100))
		output += value.charCodeAt(0)+"\t"+percent+"\n"
	}
	output += "\nEntropy: "+entropy
	document.getElementById('textOut').innerHTML = output
}

let sound = new Audio("assets/short.mp3")
function wiku(){
	sound.play()
}