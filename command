sudo apt-get update
sudo apt install build-essential
git clone https://github.com/LiveOverflow/liveoverflow_youtube.git
git clone https://github.com/radareorg/radare2
cd radare2 ; sys/install.sh
--------------------------------------
gdb
r -run
break *main
set disassembly-flavor intel
disassemble main
del delete break points

--------------------------------------
radar2
s -seek
pdf -print picture
db -break
VV -view diagram
aaa -analysis
afl -list functions
q -quit current session
