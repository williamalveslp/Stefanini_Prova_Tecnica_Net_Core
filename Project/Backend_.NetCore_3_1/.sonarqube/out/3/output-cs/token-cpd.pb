û
„C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Domain.Service\Services\Base\ServiceBase.cs
	namespace 	
StefaniniCore
 
. 
Domain 
. 
Services '
.' (
Services( 0
.0 1
Base1 5
{ 
public 

abstract 
class 
ServiceBase %
<% &
T& '
>' (
:) *
IDisposable+ 6
,6 7
IServiceBase8 D
<D E
TE F
>F G
whereH M
TN O
:P Q
classR W
{		 
private

 
readonly

 
IRepositoryBase

 (
<

( )
T

) *
>

* +
_repository

, 7
;

7 8
	protected 
ServiceBase 
( 
IRepositoryBase -
<- .
T. /
>/ 0

repository1 ;
); <
{ 	
_repository 
= 

repository $
;$ %
} 	
public 
T 
GetById 
( 
int 
entityId %
)% &
=>' )
_repository* 5
.5 6
GetById6 =
(= >
entityId> F
)F G
;G H
public 
T 
Insert 
( 
T 
entity  
)  !
=>" $
_repository% 0
.0 1
Insert1 7
(7 8
entity8 >
)> ?
;? @
public 
T 
Update 
( 
T 
entity  
)  !
=>" $
_repository% 0
.0 1
Update1 7
(7 8
entity8 >
)> ?
;? @
public 
void 

DeleteById 
( 
int "
entityId# +
)+ ,
=>- /
_repository0 ;
.; <

DeleteById< F
(F G
entityIdG O
)O P
;P Q
public 
void 
Dispose 
( 
) 
=>  
_repository! ,
., -
Dispose- 4
(4 5
)5 6
;6 7
public 
IList 
< 
T 
> 
GetAll 
( 
)  
=>! #
_repository$ /
./ 0
GetAll0 6
(6 7
)7 8
;8 9
} 
} ·

†C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Domain.Service\Services\ProfileTypeService.cs
	namespace 	
StefaniniCore
 
. 
Domain 
. 
Services '
.' (
Services( 0
{ 
public		 

class		 
ProfileTypeService		 #
:		$ %
ServiceBase		& 1
<		1 2
ProfileType		2 =
>		= >
,		> ?
IProfileTypeService		@ S
{

 
private 
readonly "
IProfileTypeRepository /
_repository0 ;
;; <
public 
ProfileTypeService !
(! ""
IProfileTypeRepository" 8

repository9 C
)C D
:E F
baseG K
(K L

repositoryL V
)V W
{ 	
this 
. 
_repository 
= 

repository )
;) *
} 	
public 
IList 
< 
ProfileType  
>  !
GetActivesOnly" 0
(0 1
)1 2
=>3 5
_repository 
. 
GetActivesOnly +
(+ ,
), -
;- .
} 
} ¦
ŠC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Domain.Service\Services\ProfileTypeTaskService.cs
	namespace 	
StefaniniCore
 
. 
Domain 
. 
Services '
.' (
Services( 0
{ 
public		 

class		 "
ProfileTypeTaskService		 '
:		( )
ServiceBase		* 5
<		5 6
ProfileTypeTask		6 E
>		E F
,		F G#
IProfileTypeTaskService		H _
{

 
private 
readonly &
IProfileTypeTaskRepository 3
_repository4 ?
;? @
public "
ProfileTypeTaskService %
(% &&
IProfileTypeTaskRepository& @

repositoryA K
)K L
:M N
baseO S
(S T

repositoryT ^
)^ _
{ 	
this 
. 
_repository 
= 

repository )
;) *
} 	
public 
IList 
< 
ProfileTypeTask $
>$ %
GetByProfileTypeId& 8
(8 9
int9 <
profileTypeId= J
)J K
=>L N
_repository 
. 
GetByProfileTypeId +
(+ ,
profileTypeId, 9
)9 :
;: ;
} 
} ˆ
C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Domain.Service\Services\TaskService.cs
	namespace 	
StefaniniCore
 
. 
Domain 
. 
Services '
.' (
Services( 0
{		 
public

 

class

 
TaskService

 
:

 
ServiceBase

 *
<

* +
Task

+ /
>

/ 0
,

0 1
ITaskService

2 >
{ 
private 
readonly 
ITaskRepository (
_repository) 4
;4 5
public 
TaskService 
( 
ITaskRepository *

repository+ 5
)5 6
:7 8
base9 =
(= >

repository> H
)H I
{ 	
this 
. 
_repository 
= 

repository )
;) *
} 	
public 
bool 
Exists 
( 
string !
name" &
)& '
=>' )
_repository* 5
.5 6
Exists6 <
(< =
name= A
)A B
;B C
public 
IList 
< 
Task 
> 
GetActivesOnly )
() *
)* +
=>, .
_repository 
. 
GetsActivesOnly +
(+ ,
), -
;- .
} 
} ç
…C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Domain.Service\Services\UserSystemService.cs
	namespace 	
StefaniniCore
 
. 
Domain 
. 
Services '
.' (
Services( 0
{		 
public

 

class

 
UserSystemService

 "
:

# $
ServiceBase

% 0
<

0 1

UserSystem

1 ;
>

; <
,

< =
IUserSystemService

> P
{ 
private 
readonly !
IUserSystemRepository .
_repository/ :
;: ;
public 
UserSystemService  
(  !!
IUserSystemRepository! 6

repository7 A
)A B
:C D
baseE I
(I J

repositoryJ T
)T U
{ 	
this 
. 
_repository 
= 

repository )
;) *
} 	
public 
IList 
< 

UserSystem 
>  
GetByProfileTypeId! 3
(3 4
int4 7
profileTypeId8 E
)E F
=>G I
_repository 
. 
GetByProfileTypeId *
(* +
profileTypeId+ 8
)8 9
;9 :
public 
IList 
< 

UserSystem 
>  
GetActivesOnly! /
(/ 0
)0 1
=>2 4
_repository 
. 
GetOnlyActives '
(' (
)( )
.) *
OrderBy* 1
(1 2
f2 3
=>4 6
f7 8
.8 9
UserName9 A
)A B
.B C
ToListC I
(I J
)J K
;K L
public 

UserSystem 
	GetSignIn #
(# $
string$ *
userName+ 3
,3 4
string5 ;
password< D
)D E
=>F H
_repository 
. 
	GetSignIn !
(! "
userName" *
,* +
password, 4
)4 5
;5 6
} 
} 