™
wC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Domain\Entities\ProfileType.cs
	namespace 	
StefaniniCore
 
. 
Domain 
. 
Entities '
{ 
public 

class 
ProfileType 
: 
ValueObjectBase .
{ 
public 
virtual 
string 
Name "
{# $
get% (
;( )
private* 1
set2 5
;5 6
}7 8
public		 
virtual		 
bool		 
IsActive		 $
{		% &
get		' *
;		* +
private		, 3
set		4 7
;		7 8
}		9 :
public

 
virtual

 
IList

 
<

 
ProfileTypeTask

 ,
>

, -
ProfileTypeTask

. =
{

> ?
get

@ C
;

C D
set

E H
;

H I
}

J K
public 
virtual 
IList 
< 

UserSystem '
>' (

UserSystem) 3
{4 5
get6 9
;9 :
set; >
;> ?
}@ A
	protected 
ProfileType 
( 
) 
:  !
base" &
(& '
)' (
{) *
}+ ,
public 
ProfileType 
( 
string !
name" &
)& '
:( )
base* .
(. /
)/ 0
{ 	
this 
. 
Name 
= 
name 
; 
this 
. 
IsActive 
= 
true  
;  !
this 
. 
ProfileTypeTask  
=! "
new# &
List' +
<+ ,
ProfileTypeTask, ;
>; <
(< =
)= >
;> ?
this 
. 

UserSystem 
= 
new !
List" &
<& '

UserSystem' 1
>1 2
(2 3
)3 4
;4 5
} 	
public 
void 
Update 
( 
string !
name" &
)& '
{ 	
this 
. 
Name 
= 
name 
; 
RefreshDateUpdated 
( 
)  
;  !
} 	
} 
} ï
{C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Domain\Entities\ProfileTypeTask.cs
	namespace 	
StefaniniCore
 
. 
Domain 
. 
Entities '
{ 
public 

class 
ProfileTypeTask  
{ 
public 
virtual 
int 
Id 
{ 
get  #
;# $
private% ,
set- 0
;0 1
}2 3
public 
virtual 
int 
TaskId !
{" #
get$ '
;' (
private) 0
set1 4
;4 5
}6 7
public 
virtual 
int 
ProfileTypeId (
{) *
get+ .
;. /
private0 7
set8 ;
;; <
}= >
public		 
virtual		 
ProfileType		 "
ProfileType		# .
{		/ 0
get		1 4
;		4 5
private		6 =
set		> A
;		A B
}		C D
public

 
virtual

 
Task

 
Task

  
{

! "
get

# &
;

& '
private

( /
set

0 3
;

3 4
}

5 6
	protected 
ProfileTypeTask !
(! "
)" #
{$ %
}& '
public 
ProfileTypeTask 
( 
int "
taskId# )
,) *
int+ .
	profileId/ 8
)8 9
:: ;
base< @
(@ A
)A B
{ 	
this 
. 
TaskId 
= 
taskId  
;  !
this 
. 
ProfileTypeId 
=  
	profileId! *
;* +
} 	
} 
} ∫
pC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Domain\Entities\Task.cs
	namespace 	
StefaniniCore
 
. 
Domain 
. 
Entities '
{ 
public 

class 
Task 
: 
ValueObjectBase '
{ 
public 
virtual 
string 
Name "
{# $
get% (
;( )
private* 1
set2 5
;5 6
}7 8
public

 
virtual

 
string

 
Description

 )
{

* +
get

, /
;

/ 0
private

1 8
set

9 <
;

< =
}

> ?
public 
virtual 
bool 
IsActive $
{% &
get' *
;* +
private, 3
set4 7
;7 8
}9 :
public 
virtual 
IList 
< 
ProfileTypeTask ,
>, -
ProfileTypeTask. =
{> ?
get@ C
;C D
setE H
;H I
}J K
	protected 
Task 
( 
) 
{ 
} 
public 
Task 
( 
string 
name 
,  
string! '
description( 3
)3 4
:5 6
base7 ;
(; <
)< =
{ 	
this 
. 
Name 
= 
name 
. 
Trim !
(! "
)" #
;# $
this 
. 
Description 
= 
description *
;* +
this 
. 
IsActive 
= 
true  
;  !
this 
. 
ProfileTypeTask  
=! "
new# &
List' +
<+ ,
ProfileTypeTask, ;
>; <
(< =
)= >
;> ?
} 	
public 
void 
Update 
( 
string !
name" &
,& '
string( .
description/ :
): ;
{ 	
this 
. 
Name 
= 
name 
. 
Trim !
(! "
)" #
;# $
this 
. 
Description 
= 
description *
;* +
RefreshDateUpdated 
( 
)  
;  !
} 	
}   
}!! ±
vC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Domain\Entities\UserSystem.cs
	namespace 	
StefaniniCore
 
. 
Domain 
. 
Entities '
{ 
public 

class 

UserSystem 
: 
ValueObjectBase -
{ 
public 
virtual 
string 
UserName &
{' (
get) ,
;, -
private. 5
set6 9
;9 :
}; <
public 
virtual 
string 
Password &
{' (
get) ,
;, -
private. 5
set6 9
;9 :
}; <
public		 
virtual		 
int		 
ProfileTypeId		 (
{		) *
get		+ .
;		. /
private		0 7
set		8 ;
;		; <
}		= >
public

 
virtual

 
bool

 
IsActive

 $
{

% &
get

' *
;

* +
private

, 3
set

4 7
;

7 8
}

9 :
public 
virtual 
ProfileType "
ProfileType# .
{/ 0
get1 4
;4 5
set6 9
;9 :
}; <
	protected 

UserSystem 
( 
) 
:  
base! %
(% &
)& '
{( )
}* +
public 

UserSystem 
( 
string  
userName! )
,) *
string+ 1
password2 :
,: ;
int< ?
profileTypeId@ M
)M N
:O P
baseQ U
(U V
)V W
{ 	
this 
. 
UserName 
= 
userName $
;$ %
this 
. 
Password 
= 
password $
;$ %
this 
. 
ProfileTypeId 
=  
profileTypeId! .
;. /
this 
. 
IsActive 
= 
true  
;  !
} 	
public 
void 
Update 
( 
string !
userName" *
,* +
string, 2
password3 ;
,; <
int= @
profileTypeIdA N
)N O
{ 	
this 
. 
UserName 
= 
userName $
;$ %
this 
. 
Password 
= 
password $
;$ %
this 
. 
ProfileTypeId 
=  
profileTypeId! .
;. /
RefreshDateUpdated 
( 
)  
;  !
} 	
} 
} ¯	
èC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Domain\Interfaces\Repositories\Base\IRepositoryBase.cs
	namespace 	
StefaniniCore
 
. 
Domain 
. 

Interfaces )
.) *
Repositories* 6
.6 7
Base7 ;
{ 
public 

	interface 
IRepositoryBase $
<$ %
T% &
>& '
where( -
T. /
:0 1
class2 7
{ 
T		 	
Insert		
 
(		 
T		 
entity		 
)		 
;		 
T 	
Update
 
( 
T 
entity 
) 
; 
T 	
GetById
 
( 
int 
entityId 
) 
;  
IList 
< 
T 
> 
GetAll 
( 
) 
; 
void 

DeleteById 
( 
int 
entityId $
)$ %
;% &
void 
Dispose 
( 
) 
; 
} 
} ¥
ëC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Domain\Interfaces\Repositories\IProfileTypeRepository.cs
	namespace 	
StefaniniCore
 
. 
Domain 
. 

Interfaces )
.) *
Repositories* 6
{ 
public 

	interface "
IProfileTypeRepository +
:, -
IRepositoryBase. =
<= >
ProfileType> I
>I J
{ 
IList		 
<		 
ProfileType		 
>		 
GetActivesOnly		 )
(		) *
)		* +
;		+ ,
}

 
} Ù
ïC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Domain\Interfaces\Repositories\IProfileTypeTaskRepository.cs
	namespace 	
StefaniniCore
 
. 
Domain 
. 

Interfaces )
.) *
Repositories* 6
{ 
public 

	interface &
IProfileTypeTaskRepository /
:0 1
IRepositoryBase2 A
<A B
ProfileTypeTaskB Q
>Q R
{ 
IList		 
<		 
ProfileTypeTask		 
>		 
GetByProfileTypeId		 1
(		1 2
int		2 5
profileTypeId		6 C
)		C D
;		D E
}

 
} í
äC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Domain\Interfaces\Repositories\ITaskRepository.cs
	namespace 	
StefaniniCore
 
. 
Domain 
. 

Interfaces )
.) *
Repositories* 6
{ 
public 

	interface 
ITaskRepository $
:% &
IRepositoryBase' 6
<6 7
Task7 ;
>; <
{ 
IList		 
<		 
Task		 
>		 
GetsActivesOnly		 #
(		# $
)		$ %
;		% &
bool 
Exists 
( 
string 
name 
)  
;  !
} 
} ±
êC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Domain\Interfaces\Repositories\IUserSystemRepository.cs
	namespace 	
StefaniniCore
 
. 
Domain 
. 

Interfaces )
.) *
Repositories* 6
{ 
public 

	interface !
IUserSystemRepository *
:+ ,
IRepositoryBase- <
<< =

UserSystem= G
>G H
{ 
IList		 
<		 

UserSystem		 
>		 
GetByProfileTypeId		 ,
(		, -
int		- 0
profileTypeId		1 >
)		> ?
;		? @
IList 
< 

UserSystem 
> 
GetOnlyActives (
(( )
)) *
;* +

UserSystem 
	GetSignIn 
( 
string #
userName$ ,
,, -
string. 4
password5 =
)= >
;> ?
} 
} Í	
àC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Domain\Interfaces\Services\Base\IServiceBase.cs
	namespace 	
StefaniniCore
 
. 
Domain 
. 

Interfaces )
.) *
Services* 2
.2 3
Base3 7
{ 
public 

	interface 
IServiceBase !
<! "
T" #
># $
where% *
T+ ,
:- .
class/ 4
{ 
T 	
Insert
 
( 
T 
entity 
) 
; 
T 	
Update
 
( 
T 
entity 
) 
; 
T 	
GetById
 
( 
int 
entityId 
) 
;  
IList   
<   
T   
>   
GetAll   
(   
)   
;   
void&& 

DeleteById&& 
(&& 
int&& 
entityId&& $
)&&$ %
;&&% &
void++ 
Dispose++ 
(++ 
)++ 
;++ 
},, 
}-- £
äC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Domain\Interfaces\Services\IProfileTypeService.cs
	namespace 	
StefaniniCore
 
. 
Domain 
. 

Interfaces )
.) *
Services* 2
{ 
public 

	interface 
IProfileTypeService (
:) *
IServiceBase+ 7
<7 8
ProfileType8 C
>C D
{ 
IList 
< 
ProfileType 
> 
GetActivesOnly )
() *
)* +
;+ ,
} 
} „
éC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Domain\Interfaces\Services\IProfileTypeTaskService.cs
	namespace 	
StefaniniCore
 
. 
Domain 
. 

Interfaces )
.) *
Services* 2
{ 
public 

	interface #
IProfileTypeTaskService ,
:- .
IServiceBase/ ;
<; <
ProfileTypeTask< K
>K L
{ 
IList 
< 
ProfileTypeTask 
> 
GetByProfileTypeId 1
(1 2
int2 5
profileTypeId6 C
)C D
;D E
} 
} Ä
ÉC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Domain\Interfaces\Services\ITaskService.cs
	namespace 	
StefaniniCore
 
. 
Domain 
. 

Interfaces )
.) *
Services* 2
{ 
public 

	interface 
ITaskService !
:" #
IServiceBase$ 0
<0 1
Task1 5
>5 6
{ 
IList 
< 
Task 
> 
GetActivesOnly "
(" #
)# $
;$ %
bool 
Exists 
( 
string 
name 
)  
;  !
} 
} †
âC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Domain\Interfaces\Services\IUserSystemService.cs
	namespace 	
StefaniniCore
 
. 
Domain 
. 

Interfaces )
.) *
Services* 2
{ 
public 

	interface 
IUserSystemService '
:( )
IServiceBase* 6
<6 7

UserSystem7 A
>A B
{ 
IList 
< 

UserSystem 
> 
GetByProfileTypeId ,
(, -
int- 0
profileTypeId1 >
)> ?
;? @
IList 
< 

UserSystem 
> 
GetActivesOnly (
(( )
)) *
;* +

UserSystem 
	GetSignIn 
( 
string #
userName$ ,
,, -
string. 4
password5 =
)= >
;> ?
} 
} ‘
~C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Domain\ValueObject\ValueObjectBase.cs
	namespace 	
StefaniniCore
 
. 
Domain 
. 
ValueObject *
{ 
public 

abstract 
class 
ValueObjectBase )
{ 
public 
virtual 
int 
Id 
{ 
get  #
;# $
private% ,
set- 0
;0 1
}2 3
public		 
virtual		 
DateTime		 
Date_Created		  ,
{		- .
get		/ 2
;		2 3
private		4 ;
set		< ?
;		? @
}		A B
public 
virtual 
DateTime 
Date_Updated  ,
{- .
get/ 2
;2 3
private4 ;
set< ?
;? @
}A B
	protected 
ValueObjectBase !
(! "
)" #
{ 	
var 
currentDateTime 
=  !
DateTime" *
.* +
Now+ .
;. /
this 
. 
Date_Created 
= 
currentDateTime  /
;/ 0
this 
. 
Date_Updated 
= 
currentDateTime  /
;/ 0
} 	
	protected 
void 
RefreshDateUpdated )
() *
)* +
{ 	
this 
. 
Date_Updated 
= 
DateTime  (
.( )
Now) ,
;, -
} 	
} 
} 