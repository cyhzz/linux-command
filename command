--------------------------------------
vim
hjkl - navigation
iIaA - editing
xr -making changes while in cmd mode
--------------------------------------
cloudbase install
brew install node
npm i -g @cloudbase/cli
--------------------------------------
sudo apt-get update
sudo apt install build-essential
git clone https://github.com/LiveOverflow/liveoverflow_youtube.git
git clone https://github.com/radareorg/radare2
cd radare2 ; sys/install.sh
--------------------------------------
gdb
r -run
break *main
watch watchpoints
set disassembly-flavor intel
disassemble main
del delete break points
display display everytime
info registers
info breakpoints
set var
file open new file
--------------------------------------
buffer overflow redirct essense
1.find the eip record position on stack 
2.override eip's next addr, and value in it.
#note: addr to override might not same every run, fuzzy by overflow with n nops+target addr, and locate estimate in the range
#note: (;cat)| with shell code to exe shell, can exe shell inside it, get root permission.
format overflow essense
use %n to write into the correct position(arg index) on stack with the correct value(arg length).
%<stack index>$<padding>n
--------------------------------------
ret to known addr: override target addr by ret addr itself to bypass ret addr checking.
--------------------------------------
binary
xCC INT3 breakpoint trap
--------------------------------------
shell
| connect out put of program into input of next
(;)group functions and exe seqentially
--------------------------------------
radar2
s -seek
pdf -print picture
db -break
VV -view diagram
aaa -analysis
afl -list functions
q -quit current session
