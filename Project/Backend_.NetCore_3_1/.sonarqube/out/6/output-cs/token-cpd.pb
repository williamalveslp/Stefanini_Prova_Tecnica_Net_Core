±
åC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting.Configs\ConfigurationTransfer.cs
	namespace 	
StefaniniCore
 
. 
Infra 
. 
CrossCutting *
.* +
Configs+ 2
{ 
public 

static 
class !
ConfigurationTransfer -
{ 
public 
static 
T 
	GetObject !
<! "
T" #
># $
($ %
IConfiguration% 3
configuration4 A
,A B
stringC I
customObjectPathJ Z
=[ \
null] a
)a b
{ 	
Type 
type 
= 
typeof 
( 
T  
)  !
;! "
string 
sectionName 
=  
string! '
.' (
IsNullOrEmpty( 5
(5 6
customObjectPath6 F
)F G
?H I
typeJ N
.N O
NameO S
:T U
customObjectPathV f
;f g
var 

objectData 
= 
configuration *
.* +

GetSection+ 5
(5 6
sectionName6 A
)A B
.B C
GetC F
<F G
TG H
>H I
(I J
)J K
;K L
return 

objectData 
; 
} 	
} 
} 
£C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting.Configs\DataTransfersAppSettings\BearerTokenSettings.cs
	namespace 	
StefaniniCore
 
. 
Infra 
. 
CrossCutting *
.* +
Configs+ 2
.2 3
DataTransfers3 @
{ 
public 

class 
BearerTokenSettings $
{ 
[ 	
Description	 
( 
$str B
)B C
]C D
public 
string 
Secret 
{ 
get "
;" #
set$ '
;' (
}) *
}		 
}

 Î
úC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting.Configs\DataTransfersAppSettings\CorsSettings.cs
	namespace 	
StefaniniCore
 
. 
Infra 
. 
CrossCutting *
.* +
Configs+ 2
.2 3
DataTransfers3 @
{ 
public 

class 
CorsSettings 
{ 
[ 	
Description	 
( 
$str O
)O P
]P Q
public 
string 
Key 
{ 
get 
;  
set! $
;$ %
}& '
[ 	
Description	 
( 
$str [
)[ \
]\ ]
public 
string 
OriginUrlsAllowed '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
} 
} ∞
£C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting.Configs\DataTransfersAppSettings\HeathChecksSettings.cs
	namespace 	
StefaniniCore
 
. 
Infra 
. 
CrossCutting *
.* +
Configs+ 2
.2 3
DataTransfers3 @
{ 
public 

class 
HeathChecksSettings $
{ 
public 
AppBuilderDto 

AppBuilder '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public  
ServiceCollectionDto #
ServiceCollection$ 5
{6 7
get8 ;
;; <
set= @
;@ A
}B C
public

 
class

 
AppBuilderDto

 "
{ 	
[ 
Description 
( 
$str K
)K L
]L M
public 
string 

PathString $
{% &
get' *
;* +
set, /
;/ 0
}1 2
[ 
Description 
( 
$str Q
)Q R
]R S
public 
string 
PathStringUI &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
} 	
public 
class  
ServiceCollectionDto )
{ 	
[ 
Description 
( 
$str V
)V W
]W X
public 
string 
GCInfo  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
UrlGroupDto 
UrlGroup '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 
class 
UrlGroupDto $
{ 
public 
string 
Name "
{# $
get% (
;( )
set* -
;- .
}/ 0
[ 
Description 
( 
$str K
)K L
]L M
public   
string   
Url   !
{  " #
get  $ '
;  ' (
set  ) ,
;  , -
}  . /
}!! 
}"" 	
}## 
}$$ ƒ
°C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting.Configs\DataTransfersAppSettings\SQLServerSettings.cs
	namespace 	
StefaniniCore
 
. 
Infra 
. 
CrossCutting *
.* +
Configs+ 2
.2 3
DataTransfers3 @
{ 
public 

class '
SQLServerConnectionSettings ,
{ 
[ 	
Description	 
( 
$str	 Ü
)
Ü á
]
á à
public 
string 
ConnectionString &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public

 
string

 
Environment

 !
{

" #
get

$ '
;

' (
set

) ,
;

, -
}

. /
public 
string 
DatabaseName "
{# $
get% (
;( )
set* -
;- .
}/ 0
} 
} â
üC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting.Configs\DataTransfersAppSettings\SwaggerSettings.cs
	namespace 	
StefaniniCore
 
. 
Infra 
. 
CrossCutting *
.* +
Configs+ 2
.2 3
DataTransfers3 @
{ 
public 

class 
SwaggerSettings  
{ 
public 
AppBuilderDto 

AppBuilder '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public  
ServiceCollectionDto #
ServiceCollection$ 5
{6 7
get8 ;
;; <
set= @
;@ A
}B C
public

 
class

  
ServiceCollectionDto

 )
{ 	
public 
string 
Title 
{  !
get" %
;% &
set' *
;* +
}, -
[ 
Description 
( 
$str @
)@ A
]A B
public 
string 
Version !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
Description %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 

ContactDto 
Contact %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
class 

ContactDto #
{ 
public 
string 
Name "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
string 
Email #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
string 
Url !
{" #
get$ '
;' (
set) ,
;, -
}. /
} 
} 	
public 
class 
AppBuilderDto "
{ 	
[ 
Description 
( 
$str r
)r s
]s t
public   
string   

UrlSwagger   $
{  % &
get  ' *
;  * +
set  , /
;  / 0
}  1 2
}!! 	
}"" 
}## Œ	
≠C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting.Configs\StartupConfigs\ApplicationBuilders\Cors\CorsAppBuilder.cs
	namespace 	
StefaniniCore
 
. 
Infra 
. 
CrossCutting *
.* +
Configs+ 2
.2 3
ApplicationBuilders3 F
{ 
public 

static 
class 
CorsAppBuilder &
{ 
public		 
static		 
void		 
UseCors		 "
(		" #
this		# '
IApplicationBuilder		( ;
app		< ?
,		? @
IConfiguration		A O
configuration		P ]
)		] ^
{

 	
var 
corsAppBuilderData "
=# $!
ConfigurationTransfer% :
.: ;
	GetObject; D
<D E
CorsSettingsE Q
>Q R
(R S
configurationS `
)` a
;a b
app 
. 
UseCors 
( 
corsAppBuilderData *
.* +
Key+ .
). /
;/ 0
} 	
} 
} „'
ΩC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting.Configs\StartupConfigs\ApplicationBuilders\HealthChecks\HealthChecksAppBuilder.cs
	namespace 	
StefaniniCore
 
. 
Infra 
. 
CrossCutting *
.* +
Configs+ 2
.2 3
ApplicationBuilders3 F
{ 
public 

static 
class "
HealthChecksAppBuilder .
{ 
public 
static 
void 
UseHealthChecks *
(* +
this+ /
IApplicationBuilder0 C
appD G
,G H
IConfigurationI W
configurationX e
)e f
{ 	
var 
healthChecksData  
=! "!
ConfigurationTransfer# 8
.8 9
	GetObject9 B
<B C
HeathChecksSettingsC V
>V W
(W X
configurationX e
)e f
;f g
string 

pathString 
= 
healthChecksData  0
?0 1
.1 2

AppBuilder2 <
?< =
.= >

PathString> H
;H I
string 
pathStringUI 
=  !
healthChecksData" 2
?2 3
.3 4

AppBuilder4 >
?> ?
.? @
PathStringUI@ L
;L M
app 
. 
UseHealthChecks 
(  

pathString  *
,* +
new, /
HealthCheckOptions0 B
(B C
)C D
{ 
	Predicate 
= 
_ 
=>  
true! %
,% &
ResponseWriter 
=  
WriteResponse! .
} 
) 
; 
if 
( 
! 
string 
. 
IsNullOrEmpty %
(% &
pathStringUI& 2
)2 3
)3 4
{ 
app   
.   
UseHealthChecksUI   %
(  % &
options  & -
=>  . 0
{!! 
options"" 
."" 
UIPath"" "
=""# $
pathStringUI""% 1
;""1 2
}## 
)## 
;## 
}$$ 
}%% 	
private-- 
static-- 
Task-- 
WriteResponse-- )
(--) *
HttpContext--* 5
httpContext--6 A
,--A B
HealthReport--C O
result--P V
)--V W
{.. 	
httpContext// 
.// 
Response//  
.//  !
ContentType//! ,
=//- .
$str/// A
;//A B
var00 
json00 
=00 
new00 
JObject00 "
(00" #
new11 
	JProperty11 
(11 
$str11 &
,11& '
result11( .
.11. /
Status11/ 5
.115 6
ToString116 >
(11> ?
)11? @
)11@ A
,11A B
new22 
	JProperty22 
(22 
$str22 '
,22' (
new22) ,
JObject22- 4
(224 5
result225 ;
.22; <
Entries22< C
.22C D
Select22D J
(22J K
pair22K O
=>22P R
new33 
	JProperty33 
(33 
pair33 "
.33" #
Key33# &
,33& '
new33( +
JObject33, 3
(333 4
new44 
	JProperty44 
(44 
$str44 &
,44& '
pair44( ,
.44, -
Value44- 2
.442 3
Status443 9
.449 :
ToString44: B
(44B C
)44C D
)44D E
,44E F
new55 
	JProperty55 
(55 
$str55 +
,55+ ,
pair55- 1
.551 2
Value552 7
.557 8
Description558 C
)55C D
,55D E
new66 
	JProperty66 
(66 
$str66 $
,66$ %
new66& )
JObject66* 1
(661 2
pair662 6
.666 7
Value667 <
.66< =
Data66= A
.66A B
Select66B H
(66H I
p66I J
=>66K M
new66N Q
	JProperty66R [
(66[ \
p66\ ]
.66] ^
Key66^ a
,66a b
p66c d
.66d e
Value66e j
)66j k
)66k l
)66l m
)66m n
)66n o
)66o p
)66p q
)66q r
)66r s
)66s t
;66t u
return77 
httpContext77 
.77 
Response77 '
.77' (

WriteAsync77( 2
(772 3
json773 7
.777 8
ToString778 @
(77@ A

Formatting77A K
.77K L
Indented77L T
)77T U
)77U V
;77V W
}88 	
}99 
}:: ¯
≥C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting.Configs\StartupConfigs\ApplicationBuilders\Swagger\SwaggerAppBuilder.cs
	namespace 	
StefaniniCore
 
. 
Infra 
. 
CrossCutting *
.* +
Configs+ 2
.2 3
ApplicationBuilders3 F
{ 
public 

static 
class 
SwaggerAppBuilder )
{ 
public		 
static		 
void		 

UseSwagger		 %
(		% &
this		& *
IApplicationBuilder		+ >
app		? B
,		B C
IConfiguration		D R
configuration		S `
)		` a
{

 	
var 
swaggerData 
= !
ConfigurationTransfer 3
.3 4
	GetObject4 =
<= >
SwaggerSettings> M
>M N
(N O
configurationO \
)\ ]
;] ^
string 
name 
= 
swaggerData %
.% &
ServiceCollection& 7
.7 8
Title8 =
;= >
string 
version 
= 
swaggerData (
.( )
ServiceCollection) :
.: ;
Version; B
;B C
string 
url 
= 
swaggerData $
.$ %

AppBuilder% /
./ 0

UrlSwagger0 :
;: ;
url 
= 
string 
. 
Format 
(  
url  #
,# $
version% ,
), -
;- .
app 
. 

UseSwagger 
( 
) 
; 
app 
. 
UseSwaggerUI 
( 
options $
=>% '
options 
. 
SwaggerEndpoint #
(# $
url$ '
,' (
name) -
)- .
). /
;/ 0
} 	
} 
} Á
“C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting.Configs\StartupConfigs\ServicesCollection\AuthenticationBearerJwt\AuthenticationBearerJwtCollection.cs
	namespace		 	
StefaniniCore		
 
.		 
Infra		 
.		 
CrossCutting		 *
.		* +
Configs		+ 2
.		2 3
StartupConfigs		3 A
.		A B
ServicesCollection		B T
.		T U#
AuthenticationBearerJwt		U l
{

 
public 

static 
class -
!AuthenticationBearerJwtCollection 9
{ 
public 
static 
void  
AddAuthenticationJwt /
(/ 0
this0 4
IServiceCollection5 G
servicesH P
,P Q
IConfigurationR `
configurationa n
)n o
{ 	
var 
bearerTokenSettings #
=$ %!
ConfigurationTransfer& ;
.; <
	GetObject< E
<E F
BearerTokenSettingsF Y
>Y Z
(Z [
configuration[ h
)h i
;i j
string 
secret 
= 
bearerTokenSettings /
./ 0
Secret0 6
;6 7
byte 
[ 
] 
key 
= 
Encoding !
.! "
ASCII" '
.' (
GetBytes( 0
(0 1
secret1 7
)7 8
;8 9
services 
. 
AddAuthentication &
(& '
x' (
=>) +
{ 
x 
. %
DefaultAuthenticateScheme +
=, -
JwtBearerDefaults. ?
.? @ 
AuthenticationScheme@ T
;T U
x 
. "
DefaultChallengeScheme (
=) *
JwtBearerDefaults+ <
.< = 
AuthenticationScheme= Q
;Q R
} 
) 
.   
AddJwtBearer   
(   
x   
=>   
{!! 
x"" 
.""  
RequireHttpsMetadata"" &
=""' (
false"") .
;"". /
x## 
.## 
	SaveToken## 
=## 
true## "
;##" #
x$$ 
.$$ %
TokenValidationParameters$$ +
=$$, -
new$$. 1%
TokenValidationParameters$$2 K
{%% $
ValidateIssuerSigningKey&& ,
=&&- .
true&&/ 3
,&&3 4
IssuerSigningKey'' $
=''% &
new''' * 
SymmetricSecurityKey''+ ?
(''? @
key''@ C
)''C D
,''D E
ValidateIssuer(( "
=((# $
false((% *
,((* +
ValidateAudience)) $
=))% &
false))' ,
}** 
;** 
}++ 
)++ 
;++ 
SecretConfig.. 
... 
Secret.. 
=..  !
secret.." (
;..( )
}// 	
}00 
}11 ï
¨C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting.Configs\StartupConfigs\ServicesCollection\Cors\CorsCollection.cs
	namespace 	
StefaniniCore
 
. 
Infra 
. 
CrossCutting *
.* +
Configs+ 2
.2 3
ServicesCollection3 E
{ 
public 

static 
class 
CorsCollection &
{ 
public 
static 
void 
AddCorsSettings *
(* +
this+ /
IServiceCollection0 B
servicesC K
,K L
IConfigurationM [
configuration\ i
)i j
{ 	
var 
corsData 
= !
ConfigurationTransfer 0
.0 1
	GetObject1 :
<: ;
CorsSettings; G
>G H
(H I
configurationI V
)V W
;W X
services 
. 
AddCors 
( 
options $
=>% '
{ 
options 
. 
	AddPolicy !
(! "
name" &
:& '
corsData( 0
.0 1
Key1 4
,4 5
builder6 =
=>> @
{ 
builder 
. 
WithOrigins '
(' (
corsData( 0
.0 1
OriginUrlsAllowed1 B
)B C
;C D
} 
) 
; 
} 
) 
; 
} 	
} 
} ˙
»C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting.Configs\StartupConfigs\ServicesCollection\DbContextSQLServer\SqlDatabaseContextCollection.cs
	namespace 	
StefaniniCore
 
. 
Infra 
. 
CrossCutting *
.* +
Configs+ 2
.2 3
ServicesCollection3 E
{ 
public 

static 
class (
SqlDatabaseContextCollection 4
{		 
public

 
static

 
void

 !
AddDbContextSQLServer

 0
(

0 1
this

1 5
IServiceCollection

6 H
services

I Q
,

Q R
IConfiguration

S a
configuration

b o
)

o p
{ 	
var  
sqlServerContextData $
=% &!
ConfigurationTransfer' <
.< =
	GetObject= F
<F G'
SQLServerConnectionSettingsG b
>b c
(c d
configurationd q
)q r
;r s
string 

connection 
=  
sqlServerContextData  4
.4 5
ConnectionString5 E
;E F
services 
. 
	AddScoped 
( 
_  
=>! #
new$ '
StefDbContext( 5
(5 6

connection6 @
)@ A
)A B
;B C
} 	
} 
} ≥,
∑C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting.Configs\StartupConfigs\ServicesCollection\HealthChecks\GCInfoHealthCheck.cs
	namespace		 	
StefaniniCore		
 
.		 
Infra		 
.		 
CrossCutting		 *
.		* +
Configs		+ 2
.		2 3
ServicesCollection		3 E
{

 
public 

static 
class .
"GCInfoHealthCheckBuilderExtensions :
{ 
public 
static  
IHealthChecksBuilder *
	AddGCInfo+ 4
(4 5
this  
IHealthChecksBuilder %
builder& -
,- .
string 
name 
, 
HealthStatus 
? 
failureStatus '
=( )
null* .
,. /
IEnumerable 
< 
string 
> 
tags  $
=% &
null' +
,+ ,
long 
? 
thresholdInBytes "
=# $
null% )
)) *
{ 	
builder 
. 
AddCheck 
< 
GCInfoHealthCheck .
>. /
(/ 0
name0 4
,4 5
failureStatus6 C
??D F
HealthStatusG S
.S T
DegradedT \
,\ ]
tags^ b
)b c
;c d
if 
( 
thresholdInBytes  
.  !
HasValue! )
)) *
{ 
builder 
. 
Services  
.  !
	Configure! *
<* +
GCInfoOptions+ 8
>8 9
(9 :
name: >
,> ?
options@ G
=>H J
{ 
options 
. 
	Threshold %
=& '
thresholdInBytes( 8
.8 9
Value9 >
;> ?
}   
)   
;   
}!! 
return## 
builder## 
;## 
}$$ 	
}%% 
public'' 

class'' 
GCInfoHealthCheck'' "
:''# $
IHealthCheck''% 1
{(( 
private)) 
readonly)) 
IOptionsMonitor)) (
<))( )
GCInfoOptions))) 6
>))6 7
_options))8 @
;))@ A
public++ 
GCInfoHealthCheck++  
(++  !
IOptionsMonitor++! 0
<++0 1
GCInfoOptions++1 >
>++> ?
options++@ G
)++G H
{,, 	
_options-- 
=-- 
options-- 
;-- 
}.. 	
public00 
Task00 
<00 
HealthCheckResult00 %
>00% &
CheckHealthAsync00' 7
(007 8
HealthCheckContext008 J
context00K R
,00R S
CancellationToken00T e
cancellationToken00f w
=00x y
default	00z Å
(
00Å Ç
CancellationToken
00Ç ì
)
00ì î
)
00î ï
{11 	
var22 
options22 
=22 
_options22 "
.22" #
Get22# &
(22& '
context22' .
.22. /
Registration22/ ;
.22; <
Name22< @
)22@ A
;22A B
var88 
	allocated88 
=88 
GC88 
.88 
GetTotalMemory88 -
(88- .
forceFullCollection88. A
:88A B
false88C H
)88H I
;88I J
var99 
data99 
=99 
new99 

Dictionary99 %
<99% &
string99& ,
,99, -
object99. 4
>994 5
(995 6
)996 7
{:: 
{;; 
$str;; 
,;; 
	allocated;; (
};;) *
,;;* +
{<< 
$str<< #
,<<# $
GC<<% '
.<<' (
CollectionCount<<( 7
(<<7 8
$num<<8 9
)<<9 :
}<<; <
,<<< =
{== 
$str== #
,==# $
GC==% '
.==' (
CollectionCount==( 7
(==7 8
$num==8 9
)==9 :
}==; <
,==< =
{>> 
$str>> #
,>># $
GC>>% '
.>>' (
CollectionCount>>( 7
(>>7 8
$num>>8 9
)>>9 :
}>>; <
,>>< =
}?? 
;?? 
varEE 
resultEE 
=EE 
	allocatedEE "
>=EE# %
optionsEE& -
.EE- .
	ThresholdEE. 7
?EE8 9
contextEE: A
.EEA B
RegistrationEEB N
.EEN O
FailureStatusEEO \
:EE] ^
HealthStatusEE_ k
.EEk l
HealthyEEl s
;EEs t
returnGG 
TaskGG 
.GG 

FromResultGG "
(GG" #
newGG# &
HealthCheckResultGG' 8
(GG8 9
resultHH 
,HH 
descriptionII 
:II 
$strII P
,IIP Q
dataJJ 
:JJ 
dataJJ 
)JJ 
)JJ 
;JJ 
}KK 	
}LL 
publicNN 

classNN 
GCInfoOptionsNN 
{OO 
publicQQ 
longQQ 
	ThresholdQQ 
{QQ 
getQQ  #
;QQ# $
setQQ% (
;QQ( )
}QQ* +
=QQ, -
$numQQ. 3
*QQ4 5
$numQQ6 ;
*QQ< =
$numQQ> C
;QQC D
}RR 
}SS ⁄
ºC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting.Configs\StartupConfigs\ServicesCollection\HealthChecks\HealthChecksCollection.cs
	namespace 	
StefaniniCore
 
. 
Infra 
. 
CrossCutting *
.* +
Configs+ 2
.2 3
ServicesCollection3 E
{ 
public 

static 
class "
HealthChecksCollection .
{		 
public

 
static

 
void

 
AddHealthChecks

 *
(

* +
this

+ /
IServiceCollection

0 B
services

C K
,

K L
IConfiguration

M [
configuration

\ i
)

i j
{ 	
var 
healthChecksData  
=! "!
ConfigurationTransfer# 8
.8 9
	GetObject9 B
<B C
HeathChecksSettingsC V
>V W
(W X
configurationX e
)e f
;f g
var 
dbContextSQLData  
=! "!
ConfigurationTransfer# 8
.8 9
	GetObject9 B
<B C'
SQLServerConnectionSettingsC ^
>^ _
(_ `
configuration` m
)m n
;n o
string 
gcInfo 
= 
healthChecksData ,
., -
ServiceCollection- >
.> ?
GCInfo? E
;E F
string 
urlGroupName 
=  !
healthChecksData" 2
.2 3
ServiceCollection3 D
.D E
UrlGroupE M
.M N
NameN R
;R S
string 
urlGroup 
= 
healthChecksData .
.. /
ServiceCollection/ @
.@ A
UrlGroupA I
.I J
UrlJ M
;M N
string 
connectionString #
=$ %
dbContextSQLData& 6
.6 7
ConnectionString7 G
;G H
string 
databaseName 
=  !
dbContextSQLData" 2
.2 3
DatabaseName3 ?
;? @
services 
. 
AddHealthChecks $
($ %
)% &
. 
	AddGCInfo 
( 
gcInfo 
)  
. 
AddSQLServerInfo 
(  
databaseName  ,
,, -
connectionString. >
)> ?
. 
AddUrlGroup 
( 
new 
Uri "
(" #
urlGroup# +
)+ ,
,, -
name. 2
:2 3
urlGroupName4 @
)@ A
. +
AddApplicationInsightsPublisher .
(. /
)/ 0
;0 1
services 
. 
AddHealthChecksUI &
(& '
)' (
. 
AddInMemoryStorage #
(# $
)$ %
;% &
} 	
} 
}   ç
∫C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting.Configs\StartupConfigs\ServicesCollection\HealthChecks\SqlServerHealthCheck.cs
	namespace 	
StefaniniCore
 
. 
Infra 
. 
CrossCutting *
.* +
Configs+ 2
.2 3
ServicesCollection3 E
{ 
public 

static 
class  
SqlServerHealthCheck ,
{		 
public 
static  
IHealthChecksBuilder *
AddSQLServerInfo+ ;
(; <
this  
IHealthChecksBuilder $
builder% ,
,, -
string 
name 
, 
string 
connectionString "
," #
HealthStatus 
? 
failureStatus &
=' (
null) -
,- .
IEnumerable 
< 
string 
> 
tags #
=$ %
null& *
,* +
long 
? 
thresholdInBytes !
=" #
null$ (
)( )
{ 	
builder 
. 
AddSqlServer  
(  !
connectionString! 1
,1 2
null3 7
,7 8
name9 =
,= >
failureStatus   +
??  , .
HealthStatus  / ;
.  ; <
Degraded  < D
,  D E
tags  F J
,!! 
TimeSpan!!  (
.!!( )
FromSeconds!!) 4
(!!4 5
$num!!5 7
)!!7 8
)!!8 9
;!!9 :
return## 
builder## 
;## 
}$$ 	
}%% 
}&& ç
≤C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting.Configs\StartupConfigs\ServicesCollection\Swagger\SwaggerCollection.cs
	namespace		 	
StefaniniCore		
 
.		 
Infra		 
.		 
CrossCutting		 *
.		* +
Configs		+ 2
.		2 3
ServicesCollection		3 E
{

 
public 

static 
class 
SwaggerCollection )
{ 
public 
static 
void 

AddSwagger %
(% &
this& *
IServiceCollection+ =
services> F
,F G
IConfigurationH V
configurationW d
)d e
{ 	
var 
swaggerData 
= !
ConfigurationTransfer 3
.3 4
	GetObject4 =
<= >
SwaggerSettings> M
>M N
(N O
configurationO \
)\ ]
;] ^
_ 
= 
services 
. 
AddSwaggerGen &
(& '
c' (
=>) +
{ 
c 
. 
EnableAnnotations #
(# $
)$ %
;% &
c 
. 

SwaggerDoc 
( 
swaggerData (
.( )
ServiceCollection) :
.: ;
Version; B
,B C
new 
OpenApiInfo #
{ 
Title 
= 
swaggerData  +
.+ ,
ServiceCollection, =
.= >
Title> C
,C D
Version 
=  !
swaggerData" -
.- .
ServiceCollection. ?
.? @
Version@ G
,G H
Description #
=$ %
swaggerData& 1
.1 2
ServiceCollection2 C
.C D
DescriptionD O
,O P
Contact 
=  !
new" %
OpenApiContact& 4
{ 
Name  
=! "
swaggerData# .
.. /
ServiceCollection/ @
.@ A
ContactA H
?H I
.I J
NameJ N
,N O
Email !
=" #
swaggerData$ /
./ 0
ServiceCollection0 A
.A B
ContactB I
?I J
.J K
EmailK P
,P Q
Url 
=  !
new" %
Uri& )
() *
swaggerData* 5
.5 6
ServiceCollection6 G
.G H
ContactH O
?O P
.P Q
UrlQ T
)T U
}   
}!! 
)!! 
;!! 
var$$ 
xmlFile$$ 
=$$ 
$"$$  
{$$  !
Assembly$$! )
.$$) * 
GetExecutingAssembly$$* >
($$> ?
)$$? @
.$$@ A
GetName$$A H
($$H I
)$$I J
.$$J K
Name$$K O
}$$O P
.xml$$P T
"$$T U
;$$U V
var%% 
xmlPath%% 
=%% 
Path%% "
.%%" #
Combine%%# *
(%%* +

AppContext%%+ 5
.%%5 6
BaseDirectory%%6 C
,%%C D
xmlFile%%E L
)%%L M
;%%M N
if'' 
('' 
!'' 
File'' 
.'' 
Exists''  
(''  !
xmlPath''! (
)''( )
)'') *
return''+ 1
;''1 2
c)) 
.)) 
IncludeXmlComments)) $
())$ %
xmlPath))% ,
))), -
;))- .
}** 
)** 
;** 
}++ 	
},, 
}-- ƒ
ôC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting.Configs\TokenBearerJwt\Models\SecretConfig.cs
	namespace 	
StefaniniCore
 
. 
Infra 
. 
CrossCutting *
.* +
Configs+ 2
.2 3
TokenBearerJwt3 A
.A B
ModelsB H
{ 
public 

static 
class 
SecretConfig $
{ 
public 
static 
string 
Secret #
{$ %
get& )
;) *
set+ .
;. /
}0 1
} 
} €
îC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting.Configs\TokenBearerJwt\Models\UserJwt.cs
	namespace 	
StefaniniCore
 
. 
Infra 
. 
CrossCutting *
.* +
Configs+ 2
.2 3
TokenBearerJwt3 A
.A B
ModelsB H
{ 
public 

class 
UserJwt 
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
public 
string 
Username 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Password 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Role 
{ 
get  
;  !
set" %
;% &
}' (
}		 
}

 Ó
öC:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting.Configs\TokenBearerJwt\TokenBearerJwtConfig.cs
	namespace 	
StefaniniCore
 
. 
Infra 
. 
CrossCutting *
.* +
Configs+ 2
.2 3
TokenBearerJwt3 A
{		 
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
TokenBearerJwtConfig

 ,
{ 
public 
static 
string 
GenerateToken *
(* +
UserJwt+ 2
userJwt3 :
): ;
{ 	
return$$ 
null$$ 
;$$ 
}%% 	
}&& 
}'' 