print('Привет! Давай поиграем!')

boardSize = 3

board = [1,2,3,4,5,6,7,8,9]

def TableOutput():
	print (('_' * 4 * boardSize ) + '_')
	for i in range(boardSize):
		print ('|' + (' ' * 3 + '|') * 3)
		print ('|' + '', board[i*3], '|', board[1+i*3], '|', board[2+i*3], '|')
		print ('|'+ ('_' * 3 + '|') * 3)

def winCheck(board):
    
	win = False
 
	WinningCombination = (
     	(0,1,2), (3,4,5), (6,7,8),
     	(0,3,6), (1,4,7), (2,5,8),
     	(0,4,8), (2,4,6)
     )
 
	for pos in WinningCombination:
     
		if (board[pos[0]] == board[pos[1]] and board[pos[0]] == board[pos[2]] and board[pos[1]] == board[pos[2]] and board[pos[1]] in ('X','O')):
			win = board[pos[0]]

	return win

def players_step(index, char):
	
	if (index > 10 or index < 1 or board[index-1] in ('X','O')):
		return False

	board[index-1] = char
	return True

def ComputerStep(players, computer):
    
	availableMove = [i-1 for i in board if type(i) == int]
 
	winningMoves = (4, 0, 2, 6, 8, 1, 3, 5, 7)
 
	for char in (computer, players):
		for pos in availableMove:
			# клонируем игровую доску
			board_computer = board[:]
			board_computer[pos] = char
			if (winCheck(board_computer) != False):
				return pos

	for pos in winningMoves:
		if (pos in availableMove):
			return pos

	return False

def start():
	
	players = 'X'
	computer = 'O'
	step = 1
 
	TableOutput()

	while (step < 9) and (winCheck(board) == False):
		index = input('Ходит ' + players + '. Введите номер поля (0 - выход):')

		if (int(index) == 0):
			break

		if (players_step(int(index), players)):
			print('Удачный ход')

			step += 1	
  
			if (ComputerStep('X', 'O') != False):
				board[ComputerStep('X', 'O')] = computer
				
				step += 1
    
			TableOutput()
   
		else:
			print('Ошибка, повторите ход!')

	if (step > 8):
		print('Ничья!')
		
	else:
		print('Выиграл ' + winCheck(board))
  
start()