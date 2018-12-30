import sys, time, threading

done = False

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
		time.sleep(0.25)
		

	# tell the spinner to stop, and wait for it to do so;
	# this will clear the last cursor before the program moves on
	done = True
	spin_thread.join()
	sys.stdout.write("\r")
	sys.stdout.write(text)
	# continue with other tasks
	sys.stdout.write("\nall done\n")
	
spinner()