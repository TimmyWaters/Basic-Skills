table = [[0] * 26 for i in range(26)]

for i in range(26):
	for j in range(26):
		table[i][j] = (i + j) + 65
		if table[i][j] >= 91:
			table[i][j] -= 26
for row in table:
   print(' '.join([chr(elem) for elem in row]))