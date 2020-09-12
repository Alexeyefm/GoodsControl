# GoodsControl
App for goods control. Based on RFID technology.

The consists of 3 parts:
1) Server where DB is located.
2) Scanner where RFID equipment is connected.
3) Monitor from which you can get information about incoming/outgoing goods.

"Scanner" and server communicate over gRPC. "Scanner" send data to server.
Also "monitor" connunicate with server over gRPC. "Monitor" sends a request to server to recieve data.