# GoodsControl
App for goods control. Based on RFID technology.

The consists of 3 parts:
1) Server where DB is located.
2) Scanner where RFID equipment is connected.
3) Monitor from which you can get information about incoming/outgoing goods.

		_________________
		|		|
		|		|
	------->|    Server	|<--------
	|	|		|	 |
  gRPC	|	|_______________|	 | gRPC
	|				\|/
_________________  		_________________
|		|		|		|
|		|		|		|
|    Scanner	|		|   Monitor	|
|		|		|		|
|_______________|		|_______________|
