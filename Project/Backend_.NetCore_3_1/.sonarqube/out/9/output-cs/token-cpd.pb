ß-
C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.API\Controllers\Base\MainController.cs
	namespace 	
StefaniniCore
 
. 
API 
. 
Controllers '
.' (
Base( ,
{ 
public 

abstract 
class 
MainController (
:) *
ControllerBase+ 9
{ 
	protected 
IActionResult 

ResponseOk  *
<* +
T+ ,
>, -
(- .
T. /
entity0 6
)6 7
{ 	
return 
Ok 
( 
new 
ResponseData &
<& '
T' (
>( )
() *
entity* 0
)0 1
)1 2
;2 3
} 	
	protected 
IActionResult 
ResponseOkEmpty  /
(/ 0
)0 1
{ 	
return 
Ok 
( 
new 
ResponseData &
<& '
HttpStatusCode' 5
>5 6
(6 7
HttpStatusCode7 E
.E F
OKF H
)H I
)I J
;J K
} 	
	protected%% 
IActionResult%% 
ResponseWithError%%  1
<%%1 2
T%%2 3
>%%3 4
(%%4 5
ILogger%%5 <
<%%< =
T%%= >
>%%> ?
logger%%@ F
,%%F G
	Exception%%H Q
ex%%R T
)%%T U
{&& 	
LogError'' 
('' 
logger'' 
,'' 
ex'' 
)''  
;''  !
ErrorResponse)) 
	viewModel)) #
=))$ %
new))& )
ErrorResponse))* 7
())7 8
ex))8 :
.)): ;
Message)); B
,))B C
HttpStatusCode))D R
.))R S

BadRequest))S ]
)))] ^
;))^ _
return** 

BadRequest** 
(** 
	viewModel** '
)**' (
;**( )
}++ 	
	protected44 
IActionResult44 
ResponseWithError44  1
(441 2
ILogger442 9
<449 :
TasksController44: I
>44I J
logger44K Q
,44Q R
	Exception44S \
ex44] _
,44_ `
HttpStatusCode44a o
httpStatusCode44p ~
)44~ 
{55 	
LogError66 
(66 
logger66 
,66 
ex66 
)66  
;66  !
ErrorResponse88 
	viewModel88 #
=88$ %
new88& )
ErrorResponse88* 7
(887 8
ex888 :
.88: ;
Message88; B
,88B C
httpStatusCode88D R
)88R S
;88S T
switch:: 
(:: 
httpStatusCode:: "
)::" #
{;; 
case<< 
HttpStatusCode<< #
.<<# $

BadRequest<<$ .
:<<. /
return== 

StatusCode== %
(==% &
(==& '
int==' *
)==* +
HttpStatusCode==+ 9
.==9 :

BadRequest==: D
,==D E
	viewModel==F O
)==O P
;==P Q
case?? 
HttpStatusCode?? #
.??# $
	Forbidden??$ -
:??- .
return@@ 

StatusCode@@ %
(@@% &
(@@& '
int@@' *
)@@* +
HttpStatusCode@@+ 9
.@@9 :
	Forbidden@@: C
,@@C D
	viewModel@@E N
)@@N O
;@@O P
caseBB 
HttpStatusCodeBB #
.BB# $
NotFoundBB$ ,
:BB, -
returnCC 

StatusCodeCC %
(CC% &
(CC& '
intCC' *
)CC* +
HttpStatusCodeCC+ 9
.CC9 :
NotFoundCC: B
,CCB C
	viewModelCCD M
)CCM N
;CCN O
caseEE 
HttpStatusCodeEE #
.EE# $
InternalServerErrorEE$ 7
:EE7 8
returnFF 

StatusCodeFF %
(FF% &
(FF& '
intFF' *
)FF* +
HttpStatusCodeFF+ 9
.FF9 :
InternalServerErrorFF: M
,FFM N
	viewModelFFO X
)FFX Y
;FFY Z
defaultHH 
:HH 
returnII 

StatusCodeII %
(II% &
(II& '
intII' *
)II* +
HttpStatusCodeII+ 9
.II9 :

BadRequestII: D
,IID E
	viewModelIIF O
)IIO P
;IIP Q
}JJ 
}KK 	
privateMM 
voidMM 
LogErrorMM 
<MM 
TMM 
>MM  
(MM  !
ILoggerMM! (
<MM( )
TMM) *
>MM* +
loggerMM, 2
,MM2 3
	ExceptionMM4 =
exMM> @
)MM@ A
{NN 	
loggerOO 
.OO 
LogErrorOO 
(OO 
$"OO 
Error: OO %
{OO% &
exOO& (
.OO( )
MessageOO) 0
}OO0 1
\r\nStackTrace: OO1 A
{OOA B
exOOB D
.OOD E

StackTraceOOE O
}OOO P
\r\n\r\nOOP X
"OOX Y
)OOY Z
;OOZ [
}PP 	
}QQ 
publicSS 

classSS 
ResponseDataSS 
<SS 
TSS 
>SS  
{TT 
publicUU 
TUU 
DataUU 
{UU 
getUU 
;UU 
setUU  
;UU  !
}UU" #
publicWW 
ResponseDataWW 
(WW 
TWW 
dataWW "
)WW" #
{XX 	
thisYY 
.YY 
DataYY 
=YY 
dataYY 
;YY 
}ZZ 	
}[[ 
}\\ Ú-
‚C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.API\Controllers\ProfileTypesController.cs
	namespace 	
StefaniniCore
 
. 
API 
. 
Controllers '
{ 
[ 
ApiController 
] 
[ 
Route 

(
 
$str 
) 
] 
[ 
Produces 
( 
$str  
)  !
]! "
public 

class "
ProfileTypesController '
:( )
MainController* 8
{ 
private 
readonly 
ILogger  
<  !"
ProfileTypesController! 7
>7 8
_logger9 @
;@ A
private 
readonly "
IProfileTypeAppService /
_appService0 ;
;; <
public "
ProfileTypesController %
(% &
ILogger& -
<- ."
ProfileTypesController. D
>D E
loggerF L
,L M"
IProfileTypeAppServiceN d

appServicee o
)o p
{ 	
this 
. 
_logger 
= 
logger !
;! "
this 
. 
_appService 
= 

appService )
;) *
} 	
[ 	
HttpGet	 
( 
$str 
) 
] 
[ 	
SwaggerOperation	 
( 
Summary !
=" #
$str$ @
)@ A
]A B
[ 	 
ProducesResponseType	 
( 
typeof $
($ %&
ProfileTypeDetailViewModel% ?
)? @
,@ A
(B C
intC F
)F G
HttpStatusCodeG U
.U V
OKV X
)X Y
]Y Z
[ 	 
ProducesResponseType	 
( 
typeof $
($ %
ErrorResponse% 2
)2 3
,3 4
(5 6
int6 9
)9 :
HttpStatusCode: H
.H I

BadRequestI S
)S T
]T U
public 
IActionResult 
GetById $
($ %
int% (
id) +
)+ ,
{   	
try!! 
{"" 
return## 

ResponseOk## !
(##! "
_appService##" -
.##- .
GetById##. 5
(##5 6
id##6 8
)##8 9
)##9 :
;##: ;
}$$ 
catch%% 
(%% 
	Exception%% 
ex%% 
)%%  
{&& 
return'' 
ResponseWithError'' (
(''( )
_logger'') 0
,''0 1
ex''2 4
)''4 5
;''5 6
}(( 
})) 	
[++ 	
HttpGet++	 
]++ 
[,, 	
SwaggerOperation,,	 
(,, 
Summary,, !
=,," #
$str,,$ ;
),,; <
],,< =
[-- 	 
ProducesResponseType--	 
(-- 
typeof-- $
(--$ %$
ProfileTypeListViewModel--% =
)--= >
,--> ?
(--@ A
int--A D
)--D E
HttpStatusCode--E S
.--S T
OK--T V
)--V W
]--W X
[.. 	 
ProducesResponseType..	 
(.. 
typeof.. $
(..$ %
ErrorResponse..% 2
)..2 3
,..3 4
(..5 6
int..6 9
)..9 :
HttpStatusCode..: H
...H I

BadRequest..I S
)..S T
]..T U
public// 
IActionResult// 
Get//  
(//  !
)//! "
{00 	
try11 
{22 
return33 

ResponseOk33 !
(33! "
_appService33" -
.33- .
GetAll33. 4
(334 5
)335 6
)336 7
;337 8
}44 
catch55 
(55 
	Exception55 
ex55 
)55  
{66 
return77 
ResponseWithError77 (
(77( )
_logger77) 0
,770 1
ex772 4
)774 5
;775 6
}88 
}99 	
[;; 	

HttpDelete;;	 
(;; 
$str;; 
);; 
];; 
[<< 	
SwaggerOperation<<	 
(<< 
Summary<< !
=<<" #
$str<<$ C
)<<C D
]<<D E
[== 	 
ProducesResponseType==	 
(== 
(== 
int== "
)==" #
HttpStatusCode==# 1
.==1 2
OK==2 4
)==4 5
]==5 6
[>> 	 
ProducesResponseType>>	 
(>> 
typeof>> $
(>>$ %
ErrorResponse>>% 2
)>>2 3
,>>3 4
(>>5 6
int>>6 9
)>>9 :
HttpStatusCode>>: H
.>>H I

BadRequest>>I S
)>>S T
]>>T U
public?? 
IActionResult?? 
Delete?? #
(??# $
int??$ '
id??( *
)??* +
{@@ 	
tryAA 
{BB 
_appServiceCC 
.CC 

DeleteByIdCC &
(CC& '
idCC' )
)CC) *
;CC* +
returnDD 
ResponseOkEmptyDD &
(DD& '
)DD' (
;DD( )
}EE 
catchFF 
(FF 
	ExceptionFF 
exFF 
)FF  
{GG 
returnHH 
ResponseWithErrorHH (
(HH( )
_loggerHH) 0
,HH0 1
exHH2 4
)HH4 5
;HH5 6
}II 
}JJ 	
}KK 
}LL ŸE
{C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.API\Controllers\TasksController.cs
	namespace 	
StefaniniCore
 
. 
API 
. 
Controllers '
{ 
[ 
ApiController 
] 
[ 
Route 

(
 
$str 
) 
] 
[ 
Produces 
( 
$str  
)  !
]! "
public 

class 
TasksController  
:! "
MainController# 1
{ 
private 
readonly 
ILogger  
<  !
TasksController! 0
>0 1
_logger2 9
;9 :
private 
readonly 
ITaskAppService (
_appService) 4
;4 5
public 
TasksController 
( 
ILogger &
<& '
TasksController' 6
>6 7
logger8 >
,> ?
ITaskAppService@ O

appServiceP Z
)Z [
{ 	
this 
. 
_logger 
= 
logger !
;! "
this 
. 
_appService 
= 

appService )
;) *
} 	
[ 	
HttpGet	 
( 
$str 
) 
] 
[ 	
SwaggerOperation	 
( 
Summary !
=" #
$str$ :
): ;
]; <
[ 	 
ProducesResponseType	 
( 
typeof $
($ %
TaskDetailViewModel% 8
)8 9
,9 :
(; <
int< ?
)? @
HttpStatusCode@ N
.N O
OKO Q
)Q R
]R S
[ 	 
ProducesResponseType	 
( 
typeof $
($ %
ErrorResponse% 2
)2 3
,3 4
(5 6
int6 9
)9 :
HttpStatusCode: H
.H I

BadRequestI S
)S T
]T U
public   
IActionResult   
GetById   $
(  $ %
int  % (
id  ) +
)  + ,
{!! 	
try"" 
{## 
return$$ 

ResponseOk$$ !
($$! "
_appService$$" -
.$$- .
GetById$$. 5
($$5 6
id$$6 8
)$$8 9
)$$9 :
;$$: ;
}%% 
catch&& 
(&& 
	Exception&& 
ex&& 
)&&  
{'' 
return(( 
ResponseWithError(( (
(((( )
_logger(() 0
,((0 1
ex((2 4
)((4 5
;((5 6
})) 
}** 	
[,, 	
HttpPost,,	 
],, 
[-- 	
SwaggerOperation--	 
(-- 
Summary-- !
=--" #
$str--$ 6
)--6 7
]--7 8
[.. 	 
ProducesResponseType..	 
(.. 
typeof.. $
(..$ %
TaskDetailViewModel..% 8
)..8 9
,..9 :
(..; <
int..< ?
)..? @
HttpStatusCode..@ N
...N O
OK..O Q
)..Q R
]..R S
[// 	 
ProducesResponseType//	 
(// 
typeof// $
(//$ %
ErrorResponse//% 2
)//2 3
,//3 4
(//5 6
int//6 9
)//9 :
HttpStatusCode//: H
.//H I

BadRequest//I S
)//S T
]//T U
public00 
IActionResult00 
Insert00 #
(00# $
[00$ %
FromBody00% -
]00- .
TaskInputModel00/ =

inputModel00> H
)00H I
{11 	
try22 
{33 
return44 

ResponseOk44 !
(44! "
_appService44" -
.44- .
Save44. 2
(442 3

inputModel443 =
)44= >
)44> ?
;44? @
}55 
catch66 
(66 
	Exception66 
ex66 
)66  
{77 
return88 
ResponseWithError88 (
(88( )
_logger88) 0
,880 1
ex882 4
)884 5
;885 6
}99 
}:: 	
[<< 	
HttpPut<<	 
]<< 
[== 	
SwaggerOperation==	 
(== 
Summary== !
===" #
$str==$ 5
)==5 6
]==6 7
[>> 	 
ProducesResponseType>>	 
(>> 
typeof>> $
(>>$ %
TaskDetailViewModel>>% 8
)>>8 9
,>>9 :
(>>; <
int>>< ?
)>>? @
HttpStatusCode>>@ N
.>>N O
OK>>O Q
)>>Q R
]>>R S
[?? 	 
ProducesResponseType??	 
(?? 
typeof?? $
(??$ %
ErrorResponse??% 2
)??2 3
,??3 4
(??5 6
int??6 9
)??9 :
HttpStatusCode??: H
.??H I

BadRequest??I S
)??S T
]??T U
public@@ 
IActionResult@@ 
Update@@ #
(@@# $
[@@$ %
FromBody@@% -
]@@- .
TaskInputModel@@/ =

inputModel@@> H
)@@H I
{AA 	
tryBB 
{CC 
returnDD 

ResponseOkDD !
(DD! "
_appServiceDD" -
.DD- .
SaveDD. 2
(DD2 3

inputModelDD3 =
)DD= >
)DD> ?
;DD? @
}EE 
catchFF 
(FF 
	ExceptionFF 
exFF 
)FF  
{GG 
returnHH 
ResponseWithErrorHH (
(HH( )
_loggerHH) 0
,HH0 1
exHH2 4
)HH4 5
;HH5 6
}II 
}JJ 	
[LL 	
HttpGetLL	 
]LL 
[MM 	
SwaggerOperationMM	 
(MM 
SummaryMM !
=MM" #
$strMM$ 4
)MM4 5
]MM5 6
[NN 	 
ProducesResponseTypeNN	 
(NN 
typeofNN $
(NN$ %
TaskListViewModelNN% 6
)NN6 7
,NN7 8
(NN9 :
intNN: =
)NN= >
HttpStatusCodeNN> L
.NNL M
OKNNM O
)NNO P
]NNP Q
[OO 	 
ProducesResponseTypeOO	 
(OO 
typeofOO $
(OO$ %
ErrorResponseOO% 2
)OO2 3
,OO3 4
(OO5 6
intOO6 9
)OO9 :
HttpStatusCodeOO: H
.OOH I

BadRequestOOI S
)OOS T
]OOT U
publicPP 
IActionResultPP 
GetPP  
(PP  !
)PP! "
{QQ 	
tryRR 
{SS 
returnTT 

ResponseOkTT !
(TT! "
_appServiceTT" -
.TT- .
GetAllTT. 4
(TT4 5
)TT5 6
)TT6 7
;TT7 8
}UU 
catchVV 
(VV 
	ExceptionVV 
exVV 
)VV  
{WW 
returnXX 
ResponseWithErrorXX (
(XX( )
_loggerXX) 0
,XX0 1
exXX2 4
)XX4 5
;XX5 6
}YY 
}ZZ 	
[\\ 	

HttpDelete\\	 
(\\ 
$str\\ 
)\\ 
]\\ 
[]] 	
SwaggerOperation]]	 
(]] 
Summary]] !
=]]" #
$str]]$ =
)]]= >
]]]> ?
[^^ 	 
ProducesResponseType^^	 
(^^ 
(^^ 
int^^ "
)^^" #
HttpStatusCode^^# 1
.^^1 2
OK^^2 4
)^^4 5
]^^5 6
[__ 	 
ProducesResponseType__	 
(__ 
typeof__ $
(__$ %
ErrorResponse__% 2
)__2 3
,__3 4
(__5 6
int__6 9
)__9 :
HttpStatusCode__: H
.__H I

BadRequest__I S
)__S T
]__T U
public`` 
IActionResult`` 
Delete`` #
(``# $
int``$ '
id``( *
)``* +
{aa 	
trybb 
{cc 
_appServicedd 
.dd 

DeleteByIddd &
(dd& '
iddd' )
)dd) *
;dd* +
returnee 
ResponseOkEmptyee &
(ee& '
)ee' (
;ee( )
}ff 
catchgg 
(gg 
	Exceptiongg 
exgg 
)gg  
{hh 
returnii 
ResponseWithErrorii (
(ii( )
_loggerii) 0
,ii0 1
exii2 4
)ii4 5
;ii5 6
}jj 
}kk 	
}ll 
}mm â

gC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.API\Program.cs
	namespace 	
StefaniniCore
 
. 
API 
{ 
public 

class 
Program 
{ 
public 
static 
void 
Main 
(  
string  &
[& '
]' (
args) -
)- .
{		 	
CreateHostBuilder

 
(

 
args

 "
)

" #
.

# $
Build

$ )
(

) *
)

* +
.

+ ,
Run

, /
(

/ 0
)

0 1
;

1 2
} 	
public 
static 
IHostBuilder "
CreateHostBuilder# 4
(4 5
string5 ;
[; <
]< =
args> B
)B C
=>D F
Host 
.  
CreateDefaultBuilder %
(% &
args& *
)* +
. $
ConfigureWebHostDefaults )
() *

webBuilder* 4
=>5 7
{ 

webBuilder 
. 

UseStartup )
<) *
Startup* 1
>1 2
(2 3
)3 4
;4 5
} 
) 
; 
} 
} ÷
gC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.API\Startup.cs
	namespace 	
StefaniniCore
 
. 
API 
{ 
public 

class 
Startup 
{ 
public 
IConfiguration 
Configuration +
{, -
get. 1
;1 2
}3 4
public 
Startup 
( 
IConfiguration %
configuration& 3
)3 4
{ 	
Configuration 
= 
configuration )
;) *
} 	
public 
void 
ConfigureServices %
(% &
IServiceCollection& 8
services9 A
)A B
{ 	
services 
. 
AddControllers #
(# $
)$ %
. 
AddJsonOptions 
(  
options  '
=>( *
{ 
options 
. !
JsonSerializerOptions 1
.1 2
WriteIndented2 ?
=@ A
trueB F
;F G
} 
) 
; 
services   
.   !
AddDbContextSQLServer   *
(  * +
Configuration  + 8
)  8 9
;  9 :
services## 
.## #
AddDependencyInjections## ,
(##, -
)##- .
;##. /
services&& 
.&& 
AddCorsSettings&& $
(&&$ %
Configuration&&% 2
)&&2 3
;&&3 4
services)) 
.)) 

AddSwagger)) 
())  
Configuration))  -
)))- .
;)). /
services,, 
.,, 
AddHealthChecks,, $
(,,$ %
Configuration,,% 2
),,2 3
;,,3 4
services// 
.//  
AddAuthenticationJwt// )
(//) *
Configuration//* 7
)//7 8
;//8 9
}00 	
public33 
void33 
	Configure33 
(33 
IApplicationBuilder33 1
app332 5
,335 6
IWebHostEnvironment337 J
env33K N
)33N O
{44 	
if55 
(55 
env55 
.55 
IsDevelopment55 !
(55! "
)55" #
)55# $
{66 
app77 
.77 %
UseDeveloperExceptionPage77 -
(77- .
)77. /
;77/ 0
}88 
app:: 
.:: 

UseRouting:: 
(:: 
):: 
;:: 
app== 
.== 
UseCors== 
(== 
Configuration== %
)==% &
;==& '
app@@ 
.@@ 
UseAuthentication@@ !
(@@! "
)@@" #
;@@# $
appCC 
.CC 
UseAuthorizationCC  
(CC  !
)CC! "
;CC" #
appEE 
.EE 
UseEndpointsEE 
(EE 
	endpointsEE &
=>EE' )
{FF 
	endpointsGG 
.GG 
MapControllersGG (
(GG( )
)GG) *
;GG* +
	endpointsHH 
.HH 
MapHealthChecksUIHH +
(HH+ ,
)HH, -
;HH- .
}II 
)II 
;II 
appLL 
.LL 

UseSwaggerLL 
(LL 
ConfigurationLL (
)LL( )
;LL) *
appOO 
.OO 
UseHealthChecksOO 
(OO  
ConfigurationOO  -
)OO- .
;OO. /
}PP 	
}QQ 
}RR 