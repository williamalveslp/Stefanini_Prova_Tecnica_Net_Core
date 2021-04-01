Ñ
ŒC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting\Constants\ConstAuthentication.cs
	namespace 	
StefaniniCore
 
. 
Infra 
. 
CrossCutting *
.* +
	Constants+ 4
{ 
public 

static 
class 
ConstAuthentication +
{ 
public 
const 
string 

CookieName &
=' (
$str) :
;: ;
public 
const 
string 

SchemeName &
=' (
$str) F
;F G
public		 
const		 
string		 
RedirectionUrl		 *
=		+ ,
$str		- B
;		B C
}

 
} § 
C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting\HashSha256Generate.cs
	namespace 	
StefaniniCore
 
. 
Infra 
. 
CrossCutting *
{ 
public

 

static

 
class

 
HashSha256Generate

 *
{ 
public 
static 
bool 
HasSameHash &
(& '
string' -
text. 2
)2 3
{ 	
using 
( 
SHA256 

sha256Hash $
=% &
SHA256' -
.- .
Create. 4
(4 5
)5 6
)6 7
{ 
string 
hash 
= 
GetHash %
(% &

sha256Hash& 0
,0 1
text2 6
)6 7
;7 8
bool 
hasSameHash  
=! "

VerifyHash# -
(- .

sha256Hash. 8
,8 9
text: >
,> ?
hash@ D
)D E
;E F
return 
hasSameHash "
;" #
} 
} 	
public## 
static## 
string## 
Generate## %
(##% &
string##& ,
text##- 1
)##1 2
{$$ 	
using%% 
(%% 
SHA256%% 

sha256Hash%% $
=%%% &
SHA256%%' -
.%%- .
Create%%. 4
(%%4 5
)%%5 6
)%%6 7
{&& 
string'' 
hash'' 
='' 
GetHash'' %
(''% &

sha256Hash''& 0
,''0 1
text''2 6
)''6 7
;''7 8
return(( 
hash(( 
;(( 
})) 
}** 	
private-- 
static-- 
string-- 
GetHash-- %
(--% &
HashAlgorithm--& 3
hashAlgorithm--4 A
,--A B
string--C I
input--J O
)--O P
{.. 	
byte00 
[00 
]00 
data00 
=00 
hashAlgorithm00 '
.00' (
ComputeHash00( 3
(003 4
Encoding004 <
.00< =
UTF800= A
.00A B
GetBytes00B J
(00J K
input00K P
)00P Q
)00Q R
;00R S
var44 
sBuilder44 
=44 
new44 
StringBuilder44 ,
(44, -
)44- .
;44. /
for88 
(88 
int88 
i88 
=88 
$num88 
;88 
i88 
<88 
data88  $
.88$ %
Length88% +
;88+ ,
i88- .
++88. 0
)880 1
{99 
sBuilder:: 
.:: 
Append:: 
(::  
data::  $
[::$ %
i::% &
]::& '
.::' (
ToString::( 0
(::0 1
$str::1 5
)::5 6
)::6 7
;::7 8
};; 
return>> 
sBuilder>> 
.>> 
ToString>> $
(>>$ %
)>>% &
;>>& '
}?? 	
privateBB 
staticBB 
boolBB 

VerifyHashBB &
(BB& '
HashAlgorithmBB' 4
hashAlgorithmBB5 B
,BBB C
stringBBD J
inputBBK P
,BBP Q
stringBBR X
hashBBY ]
)BB] ^
{CC 	
varEE 
hashOfInputEE 
=EE 
GetHashEE %
(EE% &
hashAlgorithmEE& 3
,EE3 4
inputEE5 :
)EE: ;
;EE; <
StringComparerHH 
comparerHH #
=HH$ %
StringComparerHH& 4
.HH4 5
OrdinalIgnoreCaseHH5 F
;HHF G
returnJJ 
comparerJJ 
.JJ 
CompareJJ #
(JJ# $
hashOfInputJJ$ /
,JJ/ 0
hashJJ1 5
)JJ5 6
==JJ7 9
$numJJ: ;
;JJ; <
}KK 	
}MM 
}NN 