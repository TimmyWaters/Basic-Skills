import sys, time, threading

done = False
alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
mIndex = ""
kIndex = ""
inMsg = ""
enKey = ""

def spin_cursor():
    while True:
        for cursor in '|/-\\':
            sys.stdout.write(cursor)
            sys.stdout.flush()
            time.sleep(0.1) # adjust this to change the speed
            sys.stdout.write('\b')
            global done
            if done:
                return

# start the spinner in a separate thread
def spinner():
	global done
	spin_thread = threading.Thread(target=spin_cursor)
	spin_thread.start()

	text = "    **** Vigenere Cipher ****      "
	textArray = list(text)
	# do some more work in the main thread, or just sleep:
	# time.sleep(1)

	for i in range(len(textArray)):
		sys.stdout.write('\r')
		for x in range(i):
			sys.stdout.write(textArray[x])
		time.sleep(0.2)
		
	time.sleep(1)
	# tell the spinner to stop, and wait for it to do so;
	# this will clear the last cursor before the program moves on
	done = True
	spin_thread.join()
	sys.stdout.write("\r")
	sys.stdout.write(text)
	# continue with other tasks
	sys.stdout.write("\n\n")

def getMsg():
	global alpha
	global mIndex
	
	mIndex = ""
	inMsg = ""
	
	inMsg = input("\n\nEnter the message: ").upper()
	
	for i in inMsg:
		for x in alpha:
			if i == x:
				mIndex += x

def getKey():
	global mIndex
	global kIndex
	global alpha
	
	kIndex = ""
	enKey = ""
	
	inKey = input("Enter the key: ").upper()
	for i in range(len(mIndex)):
		enKey += inKey[i%len(inKey)]
	
	for j in enKey:
		for k in alpha:
			if j == k:
				kIndex += k

def encrypt():
	getMsg()
	getKey()
	
	global kIndex
	global mIndex
	global alpha
	cipher = ""
	
	for i in range(len(mIndex)):
		x = (ord(mIndex[i]) + ord(kIndex[i])) % 26
		cipher += alpha[x]
	print("The encoded message: " + cipher + "\n\n")
	menu()

def decrypt():
	getMsg()
	getKey()
	
	global kIndex
	global mIndex
	global alpha
	cipher = ""
	
	for i in range(len(mIndex)):
		x = (ord(mIndex[i]) - ord(kIndex[i])) % 26
		cipher += alpha[x]
	print("The decoded message: " + cipher + "\n\n")
	menu()

def notOption():
	print("\nNot a choice\n")
	time.sleep(2)
	menu()

def exitProgram():
	raise SystemExit()

	
# Main Menu
def menu():
	print("1. Encrypt")
	print("2. Decrypt")
	print("3. Exit")
	choice = input("Enter choice: ")
	
	select = {'1': encrypt, '2': decrypt, '3': exitProgram}
	if choice in select:
		select[choice]()
	else:
		notOption()

### Main Area ###
spinner()
menu()