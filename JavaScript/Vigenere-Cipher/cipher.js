function ascii(x) {
	return x.charCodeAt(0);
}

function encrypt() {
	var alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	var msgStr = "";
	var keyTemp = "";
	var keyStr = "";
	var output = "";
	var input = document.getElementById("inMsg").value;
	var key = document.getElementById("key").value;
	
	input = input.toUpperCase();
	key = key.toUpperCase();
	
	for(let i = 0; i < input.length; i++) {
		for(let x = 0; x < alpha.length; x++) {
			if (input[i] == alpha[x]) {
				msgStr += alpha[x];
			}
		}
	}
	
	for(let i = 0; i < msgStr.length; i++) {
		keyTemp += key[i % key.length]
	}
	
	for(let i = 0; i < keyTemp.length; i++) {
		for(let x = 0; x < alpha.length; x++) {
			if (keyTemp[i] == alpha[x]) {
				keyStr += alpha[x];
			}
		}
	}
	
	for(let i = 0; i < msgStr.length; i++) {
		let x = (ascii(msgStr[i]) + ascii(keyStr[i])) % 26;
		output += alpha[x];
	}
	
	document.getElementById("outMsg").value = output;
}

function decrypt() {
	var alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	var msgStr = "";
	var keyTemp = "";
	var keyStr = "";
	var output = "";
	var input = document.getElementById("inMsg").value;
	var key = document.getElementById("key").value;
	
	input = input.toUpperCase();
	key = key.toUpperCase();
	
	for(let i = 0; i < input.length; i++) {
		for(let x = 0; x < alpha.length; x++) {
			if (input[i] == alpha[x]) {
				msgStr += alpha[x];
			}
		}
	}
	
	for(let i = 0; i < msgStr.length; i++) {
		keyTemp += key[i % key.length]
	}
	
	for(let i = 0; i < keyTemp.length; i++) {
		for(let x = 0; x < alpha.length; x++) {
			if (keyTemp[i] == alpha[x]) {
				keyStr += alpha[x];
			}
		}
	}
	
	for(let i = 0; i < msgStr.length; i++) {
		let x = (((ascii(msgStr[i]) - ascii(keyStr[i])) % 26) + 26) % 26;
		output += alpha[x];
	}
	
	document.getElementById("outMsg").value = output;
}