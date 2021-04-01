è
äC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\AppInterfaces\Base\IBaseAppService.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $
AppInterfaces$ 1
{ 
public 

	interface 
IBaseAppService $
{ 
} 
} Œ	
åC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\AppInterfaces\IProfileTypeAppService.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $
AppInterfaces$ 1
{ 
public 

	interface "
IProfileTypeAppService +
:, -
IBaseAppService. =
{ &
ProfileTypeDetailViewModel		 "
GetById		# *
(		* +
int		+ .
id		/ 1
)		1 2
;		2 3$
ProfileTypeListViewModel  
GetAll! '
(' (
)( )
;) *&
ProfileTypeDetailViewModel "
GetListsPopulated# 4
(4 5
)5 6
;6 7
ProfileType 
Save 
( !
ProfileTypeInputModel .

inputModel/ 9
)9 :
;: ;
void 
ValidationsToSave 
( !
ProfileTypeInputModel 4

inputModel5 ?
)? @
;@ A
void 

DeleteById 
( 
int 
id 
) 
;  
} 
} ∏
ÖC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\AppInterfaces\ITaskAppService.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $
AppInterfaces$ 1
{ 
public 

	interface 
ITaskAppService $
:% &
IBaseAppService' 6
{ 
TaskDetailViewModel 
GetById #
(# $
int$ '
id( *
)* +
;+ ,
TaskListViewModel

 
GetAll

  
(

  !
)

! "
;

" #
TaskDetailViewModel 
Save  
(  !
TaskInputModel! /

inputModel0 :
): ;
;; <
void 
ValidationsToSave 
( 
TaskInputModel -

inputModel. 8
)8 9
;9 :
void 

DeleteById 
( 
int 
id 
) 
;  
} 
} Ñ	
ãC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\AppInterfaces\IUserSystemAppService.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $
AppInterfaces$ 1
{ 
public 

	interface !
IUserSystemAppService *
:+ ,
IBaseAppService- <
{ %
UserSystemDetailViewModel		 !
GetById		" )
(		) *
int		* -
id		. 0
)		0 1
;		1 2%
UserSystemDetailViewModel !
GetListsPopulated" 3
(3 4
)4 5
;5 6

UserSystem 
	GetSignIn 
( &
UserSystemSignInInputModel 7

inputModel8 B
)B C
;C D

UserSystem 
Save 
(  
UserSystemInputModel ,

inputModel- 7
)7 8
;8 9
void 
ValidationsToSave 
(  
UserSystemInputModel 3

inputModel4 >
)> ?
;? @
} 
} “
áC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\AppServices\Base\BaseAppService.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $
AppServices$ /
./ 0
Base0 4
{ 
public 

class 
BaseAppService 
:  !
IBaseAppService" 1
{ 
} 
} ´j
âC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\AppServices\ProfileTypeAppService.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $
AppServices$ /
{ 
public 

class !
ProfileTypeAppService &
:' (
BaseAppService) 7
,7 8"
IProfileTypeAppService9 O
{ 
private 
readonly 
IProfileTypeService ,
_profileTypeService- @
;@ A
private 
readonly 
ITaskService %
_tasksService& 3
;3 4
private 
readonly #
IProfileTypeTaskService 0#
_profileTypeTaskService1 H
;H I
private 
readonly 
IUserSystemService +
_userSystemService, >
;> ?
public !
ProfileTypeAppService $
($ %
IProfileTypeService% 8
profileTypeService9 K
,K L
ITaskServiceM Y
tasksServiceZ f
," ##
IProfileTypeTaskService$ ;"
profileTypeTaskService< R
,R S
IUserSystemServiceT f
userSystemServiceg x
)x y
{ 	
this 
. 
_profileTypeService $
=% &
profileTypeService' 9
;9 :
this 
. 
_tasksService 
=  
tasksService! -
;- .
this 
. #
_profileTypeTaskService (
=) *"
profileTypeTaskService+ A
;A B
this 
. 
_userSystemService #
=$ %
userSystemService& 7
;7 8
} 	
public 
void 

DeleteById 
( 
int "
id# %
)% &
{ 	
var   
userSystemsList   
=    !
_userSystemService  " 4
.  4 5
GetByProfileTypeId  5 G
(  G H
id  H J
)  J K
;  K L
if"" 
("" 
userSystemsList"" 
.""  
Any""  #
(""# $
)""$ %
)""% &
throw## 
new## 
	Exception## #
(### $
$str##$ X
)##X Y
;##Y Z
var%%  
profileTypesTaskList%% $
=%%% &#
_profileTypeTaskService%%' >
.%%> ?
GetByProfileTypeId%%? Q
(%%Q R
id%%R T
)%%T U
;%%U V
foreach'' 
('' 
var'' 
item'' 
in''   
profileTypesTaskList''! 5
)''5 6#
_profileTypeTaskService(( '
.((' (

DeleteById((( 2
(((2 3
item((3 7
.((7 8
Id((8 :
)((: ;
;((; <
var** 
profileType** 
=** 
_profileTypeService** 1
.**1 2
GetById**2 9
(**9 :
id**: <
)**< =
;**= >
if,, 
(,, 
profileType,, 
!=,, 
null,, #
),,# $
_profileTypeService-- #
.--# $

DeleteById--$ .
(--. /
id--/ 1
)--1 2
;--2 3
}.. 	
public00 $
ProfileTypeListViewModel00 '
GetAll00( .
(00. /
)00/ 0
{11 	
var22 
profileTypes22 
=22 
_profileTypeService22 2
.222 3
GetAll223 9
(229 :
)22: ;
;22; <$
ProfileTypeListViewModel44 $
	viewModel44% .
=44/ 0
new441 4$
ProfileTypeListViewModel445 M
(44M N
)44N O
;44O P
	viewModel55 
.55 
Load55 
(55 
profileTypes55 '
)55' (
;55( )
return77 
	viewModel77 
;77 
}88 	
public:: &
ProfileTypeDetailViewModel:: )
GetById::* 1
(::1 2
int::2 5
id::6 8
)::8 9
{;; 	
var<< 
profileType<< 
=<< 
_profileTypeService<< 1
.<<1 2
GetById<<2 9
(<<9 :
id<<: <
)<<< =
;<<= >
if>> 
(>> 
profileType>> 
==>> 
null>> #
)>># $
throw?? 
new?? 
	Exception?? #
(??# $
$str??$ <
)??< =
;??= >
varAA 
relationAA 
=AA #
_profileTypeTaskServiceAA 2
.AA2 3
GetByProfileTypeIdAA3 E
(AAE F
idAAF H
)AAH I
.AAI J
SelectAAJ P
(AAP Q
fAAQ R
=>AAS U
fAAV W
.AAW X
TaskIdAAX ^
)AA^ _
.AA_ `
ToListAA` f
(AAf g
)AAg h
;AAh i
varBB 
tasksBB 
=BB 
_tasksServiceBB %
.BB% &
GetAllBB& ,
(BB, -
)BB- .
;BB. /
varCC 
tasksByProfileTypeCC "
=CC# $
tasksCC% *
.CC* +
WhereCC+ 0
(CC0 1
fCC1 2
=>CC3 5
relationCC6 >
.CC> ?
ContainsCC? G
(CCG H
fCCH I
.CCI J
IdCCJ L
)CCL M
)CCM N
.CCN O
ToListCCO U
(CCU V
)CCV W
;CCW X&
ProfileTypeDetailViewModelEE &
	viewModelEE' 0
=EE1 2
newEE3 6&
ProfileTypeDetailViewModelEE7 Q
(EEQ R
)EER S
;EES T
	viewModelFF 
.FF 
LoadFF 
(FF 
profileTypeFF &
.FF& '
IdFF' )
,FF) *
profileTypeFF+ 6
.FF6 7
NameFF7 ;
,FF; <
tasksFF= B
,FFB C
tasksByProfileTypeFFD V
)FFV W
;FFW X
returnHH 
	viewModelHH 
;HH 
}II 	
publicKK &
ProfileTypeDetailViewModelKK )
GetListsPopulatedKK* ;
(KK; <
)KK< =
{LL 	&
ProfileTypeDetailViewModelMM &
	viewModelMM' 0
=MM1 2
newMM3 6&
ProfileTypeDetailViewModelMM7 Q
(MMQ R
)MMR S
;MMS T
	viewModelNN 
.NN 
UpdateTasksNN !
(NN! "
_tasksServiceNN" /
.NN/ 0
GetAllNN0 6
(NN6 7
)NN7 8
)NN8 9
;NN9 :
returnPP 
	viewModelPP 
;PP 
}QQ 	
publicSS 
ProfileTypeSS 
SaveSS 
(SS  !
ProfileTypeInputModelSS  5

inputModelSS6 @
)SS@ A
{TT 	
ValidationsToSaveUU 
(UU 

inputModelUU (
)UU( )
;UU) *
ProfileTypeWW 
profileTypeWW #
;WW# $
ifYY 
(YY 

inputModelYY 
.YY 
IdYY 
<=YY  
$numYY! "
)YY" #
{ZZ 
profileType[[ 
=[[ 
new[[ !
ProfileType[[" -
([[- .

inputModel[[. 8
.[[8 9
Name[[9 =
)[[= >
;[[> ?
profileType\\ 
=\\ 
_profileTypeService\\ 1
.\\1 2
Insert\\2 8
(\\8 9
profileType\\9 D
)\\D E
;\\E F
foreach^^ 
(^^ 
var^^ 
item^^ !
in^^" $

inputModel^^% /
.^^/ 0
TaskIds^^0 7
)^^7 8
{__ 
ProfileTypeTask`` #
profileTypeTask``$ 3
=``4 5
new``6 9
ProfileTypeTask``: I
(``I J
item``J N
,``N O
profileType``P [
.``[ \
Id``\ ^
)``^ _
;``_ `#
_profileTypeTaskServiceaa +
.aa+ ,
Insertaa, 2
(aa2 3
profileTypeTaskaa3 B
)aaB C
;aaC D
}bb 
}cc 
elsedd 
{ee 
profileTypeff 
=ff 
_profileTypeServiceff 1
.ff1 2
GetByIdff2 9
(ff9 :

inputModelff: D
.ffD E
IdffE G
)ffG H
;ffH I
profileTypegg 
.gg 
Updategg "
(gg" #

inputModelgg# -
.gg- .
Namegg. 2
)gg2 3
;gg3 4
_profileTypeServiceii #
.ii# $
Updateii$ *
(ii* +
profileTypeii+ 6
)ii6 7
;ii7 8
varkk 
allProfileTypeTaskkk &
=kk' (#
_profileTypeTaskServicekk) @
.kk@ A
GetAllkkA G
(kkG H
)kkH I
;kkI J
varll 
profileTypesTaskll $
=ll% &
allProfileTypeTaskll' 9
.ll9 :
Wherell: ?
(ll? @
fll@ A
=>llB D
fllE F
.llF G
ProfileTypeIdllG T
==llU W
profileTypellX c
.llc d
Idlld f
)llf g
.llg h
ToListllh n
(lln o
)llo p
;llp q
DeleteOldRelationsnn "
(nn" #
profileTypesTasknn# 3
,nn3 4

inputModelnn5 ?
.nn? @
TaskIdsnn@ G
)nnG H
;nnH I
AddNewRelationsoo 
(oo  

inputModeloo  *
.oo* +
TaskIdsoo+ 2
,oo2 3
profileTypeoo4 ?
,oo? @
allProfileTypeTaskooA S
)ooS T
;ooT U
}pp 
returnqq 
profileTypeqq 
;qq 
}rr 	
privatett 
voidtt 
AddNewRelationstt $
(tt$ %
inttt% (
[tt( )
]tt) *
taskIdstt+ 2
,tt2 3
ProfileTypett4 ?
profileTypett@ K
,uu% &
IListuu' ,
<uu, -
ProfileTypeTaskuu- <
>uu< =
allProfileTypeTaskuu> P
)uuP Q
{vv 	
foreachww 
(ww 
varww 
itemww 
inww  
taskIdsww! (
)ww( )
{xx 
ifyy 
(yy 
!yy 
allProfileTypeTaskyy '
.yy' (
Anyyy( +
(yy+ ,
fyy, -
=>yy. 0
fyy1 2
.yy2 3
ProfileTypeIdyy3 @
==yyA C
profileTypeyyD O
.yyO P
IdyyP R
&&yyS U
fyyV W
.yyW X
TaskIdyyX ^
==yy_ a
itemyyb f
)yyf g
)yyg h
{zz 
ProfileTypeTask{{ #
profileTypeTask{{$ 3
={{4 5
new{{6 9
ProfileTypeTask{{: I
({{I J
item{{J N
,{{N O
profileType{{P [
.{{[ \
Id{{\ ^
){{^ _
;{{_ `#
_profileTypeTaskService|| +
.||+ ,
Insert||, 2
(||2 3
profileTypeTask||3 B
)||B C
;||C D
}}} 
}~~ 
} 	
private
ÅÅ 
void
ÅÅ  
DeleteOldRelations
ÅÅ '
(
ÅÅ' (
IList
ÅÅ( -
<
ÅÅ- .
ProfileTypeTask
ÅÅ. =
>
ÅÅ= >
profileTypesTask
ÅÅ? O
,
ÅÅO P
int
ÅÅQ T
[
ÅÅT U
]
ÅÅU V
taskIds
ÅÅW ^
)
ÅÅ^ _
{
ÇÇ 	
foreach
ÉÉ 
(
ÉÉ 
var
ÉÉ 
item
ÉÉ 
in
ÉÉ  
profileTypesTask
ÉÉ! 1
)
ÉÉ1 2
{
ÑÑ 
bool
ÖÖ 
match
ÖÖ 
=
ÖÖ 
false
ÖÖ "
;
ÖÖ" #
foreach
ÜÜ 
(
ÜÜ 
var
ÜÜ 
taskIdInput
ÜÜ (
in
ÜÜ) +
taskIds
ÜÜ, 3
)
ÜÜ3 4
{
áá 
if
àà 
(
àà 
item
àà 
.
àà 
TaskId
àà #
==
àà$ &
taskIdInput
àà' 2
)
àà2 3
{
ââ 
match
ää 
=
ää 
true
ää  $
;
ää$ %
break
ãã 
;
ãã 
}
åå 
}
çç 
if
èè 
(
èè 
!
èè 
match
èè 
)
èè 
{
êê %
_profileTypeTaskService
ëë +
.
ëë+ ,

DeleteById
ëë, 6
(
ëë6 7
item
ëë7 ;
.
ëë; <
Id
ëë< >
)
ëë> ?
;
ëë? @
}
íí 
}
ìì 
}
îî 	
public
ññ 
void
ññ 
ValidationsToSave
ññ %
(
ññ% &#
ProfileTypeInputModel
ññ& ;

inputModel
ññ< F
)
ññF G
{
óó 	
var
òò 
validate
òò 
=
òò 
new
òò ,
ProfileTypeInputModelValidator
òò =
(
òò= >
)
òò> ?
.
òò? @
Validate
òò@ H
(
òòH I

inputModel
òòI S
)
òòS T
;
òòT U
if
öö 
(
öö 
!
öö 
validate
öö 
.
öö 
IsValid
öö !
)
öö! "
throw
õõ 
new
õõ 
	Exception
õõ #
(
õõ# $
validate
õõ$ ,
.
õõ, -
Errors
õõ- 3
.
õõ3 4
FirstOrDefault
õõ4 B
(
õõB C
)
õõC D
.
õõD E
ErrorMessage
õõE Q
)
õõQ R
;
õõR S
}
úú 	
}
ùù 
}ûû ‰*
ÇC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\AppServices\TaskAppService.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $
AppServices$ /
{ 
public 

class 
TaskAppService 
:  !
BaseAppService" 0
,0 1
ITaskAppService2 A
{ 
private 
readonly 
ITaskService %
_taskService& 2
;2 3
public 
TaskAppService 
( 
ITaskService *
taskService+ 6
)6 7
{ 	
_taskService 
= 
taskService &
;& '
} 	
public 
void 

DeleteById 
( 
int "
id# %
)% &
{ 	
_taskService 
. 

DeleteById #
(# $
id$ &
)& '
;' (
} 	
public 
TaskListViewModel  
GetAll! '
(' (
)( )
{ 	
var 
tasks 
= 
_taskService $
.$ %
GetAll% +
(+ ,
), -
.- .
OrderBy. 5
(5 6
f6 7
=>8 :
f; <
.< =
Id= ?
)? @
.@ A
ToListA G
(G H
)H I
;I J
TaskListViewModel 
	viewModel '
=( )
new* -
TaskListViewModel. ?
(? @
)@ A
;A B
	viewModel   
.   
Load   
(   
tasks    
)    !
;  ! "
return"" 
	viewModel"" 
;"" 
}## 	
public%% 
TaskDetailViewModel%% "
GetById%%# *
(%%* +
int%%+ .
id%%/ 1
)%%1 2
{&& 	
var'' 
task'' 
='' 
_taskService'' #
.''# $
GetById''$ +
(''+ ,
id'', .
)''. /
;''/ 0
if)) 
()) 
task)) 
==)) 
null)) 
))) 
throw** 
new** 
	Exception** #
(**# $
$str**$ D
)**D E
;**E F
TaskDetailViewModel,, 
	viewModel,,  )
=,,* +
new,,, /
TaskDetailViewModel,,0 C
(,,C D
),,D E
;,,E F
	viewModel-- 
.-- 
Load-- 
(-- 
task-- 
)--  
;--  !
return// 
	viewModel// 
;// 
}00 	
public22 
TaskDetailViewModel22 "
Save22# '
(22' (
TaskInputModel22( 6

inputModel227 A
)22A B
{33 	
ValidationsToSave44 
(44 

inputModel44 (
)44( )
;44) *
Task66 
task66 
;66 
if77 
(77 

inputModel77 
.77 
Id77 
<=77  
$num77! "
)77" #
{88 
task99 
=99 
new99 
Task99 
(99  

inputModel99  *
.99* +
Name99+ /
,99/ 0

inputModel991 ;
.99; <
Description99< G
)99G H
;99H I
_taskService:: 
.:: 
Insert:: #
(::# $
task::$ (
)::( )
;::) *
};; 
else<< 
{== 
task>> 
=>> 
_taskService>> #
.>># $
GetById>>$ +
(>>+ ,

inputModel>>, 6
.>>6 7
Id>>7 9
)>>9 :
;>>: ;
task?? 
.?? 
Update?? 
(?? 

inputModel?? &
.??& '
Name??' +
,??+ ,

inputModel??- 7
.??7 8
Description??8 C
)??C D
;??D E
_taskService@@ 
.@@ 
Update@@ #
(@@# $
task@@$ (
)@@( )
;@@) *
}AA 
TaskDetailViewModelBB 
	viewModelBB  )
=BB* +
newBB, /
TaskDetailViewModelBB0 C
(BBC D
)BBD E
;BBE F
	viewModelCC 
.CC 
LoadCC 
(CC 
taskCC 
)CC  
;CC  !
returnEE 
	viewModelEE 
;EE 
}FF 	
publicHH 
voidHH 
ValidationsToSaveHH %
(HH% &
TaskInputModelHH& 4

inputModelHH5 ?
)HH? @
{II 	
varJJ 
validateJJ 
=JJ 
newJJ #
TaskInputModelValidatorJJ 6
(JJ6 7
)JJ7 8
.JJ8 9
ValidateJJ9 A
(JJA B

inputModelJJB L
)JJL M
;JJM N
ifLL 
(LL 
!LL 
validateLL 
.LL 
IsValidLL !
)LL! "
throwMM 
newMM 
	ExceptionMM #
(MM# $
validateMM$ ,
.MM, -
ErrorsMM- 3
.MM3 4
FirstOrDefaultMM4 B
(MMB C
)MMC D
.MMD E
ErrorMessageMME Q
)MMQ R
;MMR S
}NN 	
}OO 
}PP Ù6
àC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\AppServices\UserSystemAppService.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $
AppServices$ /
{ 
public 

class  
UserSystemAppService %
:& '
BaseAppService( 6
,6 7!
IUserSystemAppService8 M
{ 
private 
readonly 
IUserSystemService +
_userSystemService, >
;> ?
private 
readonly 
IProfileTypeService ,
_profileTypeService- @
;@ A
public  
UserSystemAppService #
(# $
IUserSystemService$ 6
userSystemService7 H
,H I
IProfileTypeServiceJ ]
profileTypeService^ p
)p q
{ 	
_userSystemService 
=  
userSystemService! 2
;2 3
_profileTypeService 
=  !
profileTypeService" 4
;4 5
} 	
public %
UserSystemDetailViewModel (
GetListsPopulated) :
(: ;
); <
{ 	
var 
profileTypes 
= 
_profileTypeService 2
.2 3
GetAll3 9
(9 :
): ;
.; <
Where< A
(A B
fB C
=>D F
fG H
.H I
IsActiveI Q
)Q R
.R S
OrderByS Z
(Z [
f[ \
=>] _
f` a
.a b
Idb d
)d e
.e f
ToListf l
(l m
)m n
;n o%
UserSystemDetailViewModel %
	viewModel& /
=0 1
new2 5%
UserSystemDetailViewModel6 O
(O P
)P Q
;Q R
	viewModel 
. 
UpdateProfileTypes (
(( )
profileTypes) 5
)5 6
;6 7
return 
	viewModel 
; 
}   	
public"" %
UserSystemDetailViewModel"" (
GetById"") 0
(""0 1
int""1 4
id""5 7
)""7 8
{## 	
var$$ 

userSystem$$ 
=$$ 
_userSystemService$$ /
.$$/ 0
GetById$$0 7
($$7 8
id$$8 :
)$$: ;
;$$; <
if&& 
(&& 

userSystem&& 
==&& 
null&& "
)&&" #
throw'' 
new'' 
	Exception'' #
(''# $
$str''$ =
)''= >
;''> ?
var)) 
profileTypes)) 
=)) 
_profileTypeService)) 2
.))2 3
GetAll))3 9
())9 :
))): ;
;)); <%
UserSystemDetailViewModel++ %
	viewModel++& /
=++0 1
new++2 5%
UserSystemDetailViewModel++6 O
(++O P
)++P Q
;++Q R
	viewModel,, 
.,, 
Load,, 
(,, 

userSystem,, %
.,,% &
Id,,& (
,,,( )

userSystem,,* 4
.,,4 5
UserName,,5 =
,,,= >

userSystem,,? I
.,,I J
Password,,J R
,,,R S

userSystem,,T ^
.,,^ _
ProfileTypeId,,_ l
,,,l m
profileTypes,,n z
),,z {
;,,{ |
return.. 
	viewModel.. 
;.. 
}// 	
public11 

UserSystem11 
	GetSignIn11 #
(11# $&
UserSystemSignInInputModel11$ >

inputModel11? I
)11I J
{22 	
var33 

userSystem33 
=33 
_userSystemService33 /
.33/ 0
	GetSignIn330 9
(339 :

inputModel33: D
.33D E
UserName33E M
,33M N

inputModel33O Y
.33Y Z
Password33Z b
)33b c
;33c d
if55 
(55 

userSystem55 
==55 
null55 "
)55" #
throw66 
new66 
	Exception66 #
(66# $
$str66$ =
)66= >
;66> ?
return88 

userSystem88 
;88 
}99 	
public;; 

UserSystem;; 
Save;; 
(;;  
UserSystemInputModel;; 3

inputModel;;4 >
);;> ?
{<< 	
ValidationsToSave== 
(== 

inputModel== (
)==( )
;==) *

UserSystem?? 

userSystem?? !
;??! "
if@@ 
(@@ 

inputModel@@ 
.@@ 
Id@@ 
<=@@  
$num@@! "
)@@" #
{AA 

userSystemBB 
=BB 
newBB  

UserSystemBB! +
(BB+ ,

inputModelBB, 6
.BB6 7
UserNameBB7 ?
,BB? @

inputModelBBA K
.BBK L
PasswordBBL T
,BBT U

inputModelBBV `
.BB` a
ProfileTypeIdBBa n
)BBn o
;BBo p
_userSystemServiceCC "
.CC" #
InsertCC# )
(CC) *

userSystemCC* 4
)CC4 5
;CC5 6
}DD 
elseEE 
{FF 

userSystemGG 
=GG 
_userSystemServiceGG /
.GG/ 0
GetByIdGG0 7
(GG7 8

inputModelGG8 B
.GGB C
IdGGC E
)GGE F
;GGF G

userSystemHH 
.HH 
UpdateHH !
(HH! "

inputModelHH" ,
.HH, -
UserNameHH- 5
,HH5 6

inputModelHH7 A
.HHA B
PasswordHHB J
,HHJ K

inputModelHHL V
.HHV W
ProfileTypeIdHHW d
)HHd e
;HHe f
_userSystemServiceII "
.II" #
UpdateII# )
(II) *

userSystemII* 4
)II4 5
;II5 6
}JJ 
returnKK 

userSystemKK 
;KK 
}LL 	
publicNN 
voidNN 
ValidationsToSaveNN %
(NN% & 
UserSystemInputModelNN& :

inputModelNN; E
)NNE F
{OO 	
varPP 
validatePP 
=PP 
newPP )
UserSystemInputModelValidatorPP <
(PP< =
)PP= >
.PP> ?
ValidatePP? G
(PPG H

inputModelPPH R
)PPR S
;PPS T
ifRR 
(RR 
!RR 
validateRR 
.RR 
IsValidRR !
)RR! "
throwSS 
newSS 
	ExceptionSS #
(SS# $
validateSS$ ,
.SS, -
ErrorsSS- 3
.SS3 4
FirstOrDefaultSS4 B
(SSB C
)SSC D
.SSD E
ErrorMessageSSE Q
)SSQ R
;SSR S
}TT 	
}UU 
}VV •
ñC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\InputModels\ProfileTypes\ProfileTypeInputModel.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $
InputModels$ /
./ 0
ProfileTypes0 <
{ 
public 

class !
ProfileTypeInputModel &
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public		 
int		 
[		 
]		 
TaskIds		 
{		 
get		 "
;		" #
set		$ '
;		' (
}		) *
}

 
} Ú
àC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\InputModels\Tasks\TaskInputModel.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $
InputModels$ /
./ 0
Tasks0 5
{ 
public 

class 
TaskInputModel 
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public		 
string		 
Description		 !
{		" #
get		$ '
;		' (
set		) ,
;		, -
}		. /
}

 
} ≤
îC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\InputModels\UserSystems\UserSystemInputModel.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $
InputModels$ /
./ 0 
UserSystemInputModel0 D
{ 
public 

class  
UserSystemInputModel %
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
UserName 
{  
get! $
;$ %
set& )
;) *
}+ ,
public		 
string		 
Password		 
{		  
get		! $
;		$ %
set		& )
;		) *
}		+ ,
public 
int 
ProfileTypeId  
{! "
get# &
;& '
set( +
;+ ,
}- .
} 
} ç
öC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\InputModels\UserSystems\UserSystemSignInInputModel.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $
InputModels$ /
./ 0 
UserSystemInputModel0 D
{ 
public 

class &
UserSystemSignInInputModel +
{ 
public 
string 
UserName 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Password 
{  
get! $
;$ %
set& )
;) *
}+ ,
} 
}		 ß	
C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\Responses\ErrorResponse.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $
	Responses$ -
{ 
public 

class 
ErrorResponse 
{		 
public

 
string

 
ErrorMessage

 "
{

# $
get

% (
;

( )
private

* 1
set

2 5
;

5 6
}

7 8
public 
HttpStatusCode 

StatusCode (
{) *
get+ .
;. /
private0 7
set8 ;
;; <
}= >
public 
ErrorResponse 
( 
string #
errorMessage$ 0
,0 1
HttpStatusCode2 @

statusCodeA K
)K L
{ 	
this 
. 
ErrorMessage 
= 
errorMessage  ,
;, -
this 
. 

StatusCode 
= 

statusCode (
;( )
} 	
} 
} ∑
~C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\Responses\ResponseBase.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $
	Responses$ -
{ 
public 

class 
ResponseBase 
< 
T 
>  
{ 
public 
T 
Data 
{ 
get 
; 
set  
;  !
}" #
} 
} Ï
ûC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\Validators\ProfileTypes\ProfileTypeInputModelValidator.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $

Validators$ .
.. /
ProfileTypes/ ;
{ 
public 

class *
ProfileTypeInputModelValidator /
:0 1
AbstractValidator2 C
<C D!
ProfileTypeInputModelD Y
>Y Z
{ 
public *
ProfileTypeInputModelValidator -
(- .
). /
{		 	
RuleFor

 
(

 
f

 
=>

 
f

 
)

 
.

 
NotNull

 #
(

# $
)

$ %
.

% &
WithMessage

& 1
(

1 2
$str

2 L
)

L M
;

M N
RuleFor 
( 
f 
=> 
f 
. 
Name 
)  
.  !
NotNull! (
(( )
)) *
.* +
NotEmpty+ 3
(3 4
)4 5
.5 6
WithMessage6 A
(A B
$strB n
)n o
;o p
RuleFor 
( 
f 
=> 
f 
. 
Name 
)  
.  !
MinimumLength! .
(. /
$num/ 0
)0 1
.1 2
WithMessage2 =
(= >
$str> {
){ |
;| }
RuleFor 
( 
f 
=> 
f 
. 
Name 
)  
.  !
MaximumLength! .
(. /
$num/ 1
)1 2
.2 3
WithMessage3 >
(> ?
$str? }
)} ~
;~ 
RuleFor 
( 
f 
=> 
f 
. 
TaskIds "
)" #
.# $
NotEmpty$ ,
(, -
)- .
.. /
WithMessage/ :
(: ;
$str; h
)h i
;i j
} 
} 
} Ω
êC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\Validators\Tasks\TaskInputModelValidator.cs
	namespace 	
StefaniniCore
 
. 
Services  
.  !

Validators! +
{ 
public 

class #
TaskInputModelValidator (
:) *
AbstractValidator+ <
<< =
TaskInputModel= K
>K L
{ 
public #
TaskInputModelValidator &
(& '
)' (
{		 	
RuleFor

 
(

 
f

 
=>

 
f

 
)

 
.

 
NotNull

 #
(

# $
)

$ %
.

% &
WithMessage

& 1
(

1 2
$str

2 L
)

L M
;

M N
RuleFor 
( 
f 
=> 
f 
. 
Name 
)  
.  !
NotNull! (
(( )
)) *
.* +
NotEmpty+ 3
(3 4
)4 5
.5 6
WithMessage6 A
(A B
$strB d
)d e
;e f
RuleFor 
( 
f 
=> 
f 
. 
Name 
)  
.  !
MinimumLength! .
(. /
$num/ 0
)0 1
.1 2
WithMessage2 =
(= >
$str> q
)q r
;r s
RuleFor 
( 
f 
=> 
f 
. 
Name 
)  
.  !
MaximumLength! .
(. /
$num/ 1
)1 2
.2 3
WithMessage3 >
(> ?
$str? s
)s t
;t u
RuleFor 
( 
f 
=> 
f 
. 
Description &
)& '
.' (
MaximumLength( 5
(5 6
$num6 9
)9 :
.: ;
WithMessage; F
(F G
$str	G Å
)
Å Ç
;
Ç É
} 	
} 
} •
úC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\Validators\UserSystems\UserSystemInputModelValidator.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $

Validators$ .
{ 
public 

class )
UserSystemInputModelValidator .
:/ 0
AbstractValidator1 B
<B C 
UserSystemInputModelC W
>W X
{ 
public )
UserSystemInputModelValidator ,
(, -
)- .
{		 	
RuleFor

 
(

 
f

 
=>

 
f

 
)

 
.

 
NotNull

 #
(

# $
)

$ %
.

% &
WithMessage

& 1
(

1 2
$str

2 L
)

L M
;

M N
RuleFor 
( 
f 
=> 
f 
. 
UserName #
)# $
.$ %
NotNull% ,
(, -
)- .
.. /
NotEmpty/ 7
(7 8
)8 9
.9 :
WithMessage: E
(E F
$strF s
)s t
;t u
RuleFor 
( 
f 
=> 
f 
. 
UserName #
)# $
.$ %
MinimumLength% 2
(2 3
$num3 4
)4 5
.5 6
WithMessage6 A
(A B
$str	B Ä
)
Ä Å
;
Å Ç
RuleFor 
( 
f 
=> 
f 
. 
UserName #
)# $
.$ %
MaximumLength% 2
(2 3
$num3 5
)5 6
.6 7
WithMessage7 B
(B C
$str	C Ç
)
Ç É
;
É Ñ
RuleFor 
( 
f 
=> 
f 
. 
Password #
)# $
.$ %
NotNull% ,
(, -
)- .
.. /
NotEmpty/ 7
(7 8
)8 9
.9 :
WithMessage: E
(E F
$strF i
)i j
;j k
RuleFor 
( 
f 
=> 
f 
. 
Password #
)# $
.$ %
MinimumLength% 2
(2 3
$num3 4
)4 5
.5 6
WithMessage6 A
(A B
$strB v
)v w
;w x
RuleFor 
( 
f 
=> 
f 
. 
Password #
)# $
.$ %
MaximumLength% 2
(2 3
$num3 5
)5 6
.6 7
WithMessage7 B
(B C
$strC x
)x y
;y z
RuleFor 
( 
f 
=> 
f 
. 
ProfileTypeId (
)( )
.) *
Must* .
(. /
f/ 0
=>0 2
f3 4
>5 6
$num7 8
)8 9
.9 :
WithMessage: E
(E F
$strF j
)j k
;k l
} 	
} 
} Ò
öC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\ViewModels\ProfileTypes\ProfileTypeDetailViewModel.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $

ViewModels$ .
{ 
public 

class &
ProfileTypeDetailViewModel +
:, -
ViewModelBase. ;
{ 
public 
virtual 
int 
Id 
{ 
get  #
;# $
set% (
;( )
}* +
public

 
virtual

 
string

 
Name

 "
{

# $
get

% (
;

( )
set

* -
;

- .
}

/ 0
public 
virtual 
IList 
< 
Task !
>! "
Tasks# (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
virtual 
IList 
< 
Task !
>! "
TasksByProfileType# 5
{6 7
get8 ;
;; <
set= @
;@ A
}B C
public &
ProfileTypeDetailViewModel )
() *
)* +
{ 	
this 
. 
Tasks 
= 
new 
List !
<! "
Task" &
>& '
(' (
)( )
;) *
this 
. 
TasksByProfileType #
=$ %
new& )
List* .
<. /
Task/ 3
>3 4
(4 5
)5 6
;6 7
} 	
public 
void 
Load 
( 
int 
id 
,  
string! '
name( ,
,, -
IList. 3
<3 4
Task4 8
>8 9
tasks: ?
,? @
IListA F
<F G
TaskG K
>K L
tasksByProfileTypeM _
)_ `
{ 	
this 
. 
Id 
= 
id 
; 
this 
. 
Name 
= 
name 
; 
this 
. 
Tasks 
= 
tasks 
; 
this 
. 
TasksByProfileType #
=$ %
tasksByProfileType& 8
;8 9
} 	
public 
void 
UpdateTasks 
(  
IList  %
<% &
Task& *
>* +
tasks, 1
)1 2
{ 	
this   
.   
Tasks   
=   
tasks   
;   
}!! 	
}"" 
}## –
òC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\ViewModels\ProfileTypes\ProfileTypeListViewModel.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $

ViewModels$ .
{ 
public 

class $
ProfileTypeListViewModel )
:* +
ViewModelBase, 9
{ 
public 
virtual 
IList 
< 
ProfileType (
>( )
ProfileTypes* 6
{7 8
get9 <
;< =
set> A
;A B
}C D
public

 
virtual

 
int

 
TotalRecords

 '
{

( )
get

* -
;

- .
set

/ 2
;

2 3
}

4 5
public 
void 
Load 
( 
IList 
< 
ProfileType *
>* +
profileTypes, 8
)8 9
{ 	
this 
. 
ProfileTypes 
= 
profileTypes  ,
;, -
this 
. 
TotalRecords 
= 
(  !
profileTypes! -
!=. 0
null1 5
)5 6
?7 8
profileTypes9 E
.E F
CountF K
:L M
$numN O
;O P
} 	
} 
} ﬁ
åC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\ViewModels\Tasks\TaskDetailViewModel.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $

ViewModels$ .
{ 
public 

class 
TaskDetailViewModel $
:% &
ViewModelBase' 4
{ 
public 
virtual 
Task 
Task  
{! "
get# &
;& '
set( +
;+ ,
}- .
public		 
void		 
Load		 
(		 
Task		 
task		 "
)		" #
{

 	
this 
. 
Task 
= 
task 
; 
} 	
} 
} Á
äC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\ViewModels\Tasks\TaskListViewModel.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $

ViewModels$ .
{ 
public 

class 
TaskListViewModel "
:# $
ViewModelBase% 2
{ 
public 
virtual 
IList 
< 
StefaniniCore *
.* +
Domain+ 1
.1 2
Entities2 :
.: ;
Task; ?
>? @
TasksA F
{G H
getI L
;L M
setN Q
;Q R
}S T
public

 
virtual

 
int

 
TotalRecords

 '
{

( )
get

* -
;

- .
set

/ 2
;

2 3
}

4 5
public 
void 
Load 
( 
IList 
< 
StefaniniCore ,
., -
Domain- 3
.3 4
Entities4 <
.< =
Task= A
>A B
tasksC H
)H I
{ 	
this 
. 
Tasks 
= 
tasks 
; 
this 
. 
TotalRecords 
= 
(  !
tasks! &
!=' )
null* .
). /
?0 1
tasks2 7
.7 8
Count8 =
:> ?
$num@ A
;A B
} 	
} 
} Â
òC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\ViewModels\UserSystems\UserSystemDetailViewModel.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $

ViewModels$ .
{ 
public 

class %
UserSystemDetailViewModel *
:+ ,
ViewModelBase- :
{ 
public 
virtual 
int 
Id 
{ 
get  #
;# $
set% (
;( )
}* +
public

 
virtual

 
string

 
UserName

 &
{

' (
get

) ,
;

, -
set

. 1
;

1 2
}

3 4
public 
virtual 
string 
Password &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
virtual 
int 
ProfileTypeId (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
virtual 
IList 
< 
ProfileType (
>( )
ProfileTypes* 6
{7 8
get9 <
;< =
set> A
;A B
}C D
public %
UserSystemDetailViewModel (
(( )
)) *
{ 	
this 
. 
ProfileTypes 
= 
new  #
List$ (
<( )
ProfileType) 4
>4 5
(5 6
)6 7
;7 8
} 	
public 
void 
Load 
( 
int 
id 
,  
string! '
userName( 0
,0 1
string2 8
password9 A
,A B
intC F
profileTypeIdG T
,T U
IListV [
<[ \
ProfileType\ g
>g h
profileTypesi u
)u v
{ 	
this 
. 
Id 
= 
id 
; 
this 
. 
UserName 
= 
userName $
;$ %
this 
. 
Password 
= 
password $
;$ %
this 
. 
ProfileTypeId 
=  
profileTypeId! .
;. /
this 
. 
ProfileTypes 
= 
profileTypes  ,
;, -
} 	
public   
void   
UpdateProfileTypes   &
(  & '
IList  ' ,
<  , -
ProfileType  - 8
>  8 9
profileTypes  : F
)  F G
{!! 	
this"" 
."" 
ProfileTypes"" 
="" 
profileTypes""  ,
;"", -
}## 	
}$$ 
}%% Ÿ	
òC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\ViewModels\UserSystems\UserSystemSignInViewModel.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $

ViewModels$ .
{ 
public 

class %
UserSystemSignInViewModel *
:+ ,
ViewModelBase- :
{ 
public 
virtual 
string 
UserName &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
virtual 
string 
Password &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public		 
void		 
Load		 
(		 
string		 
userName		  (
,		( )
string		* 0
password		1 9
)		9 :
{

 	
this 
. 
UserName 
= 
userName $
;$ %
this 
. 
Password 
= 
password $
;$ %
} 	
} 
} Ä
ÄC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Application\ViewModels\ViewModelBase.cs
	namespace 	
StefaniniCore
 
. 
Application #
.# $

ViewModels$ .
{ 
public 

abstract 
class 
ViewModelBase '
{ 
	protected 
ViewModelBase 
(  
)  !
{ 	
} 	
} 
}		 