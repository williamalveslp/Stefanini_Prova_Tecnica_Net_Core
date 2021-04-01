Æ!
‡C:\Git_Repos\Stefanini_Prova_Tecnica_Net_Core\Project\Backend_.NetCore_3_1\StefaniniCore.Infra.CrossCutting.IoC\DependencyInjections.cs
	namespace		 	
StefaniniCore		
 
.		 
Infra		 
.		 
CrossCutting		 *
.		* +
IoC		+ .
{

 
public 

static 
class  
DependencyInjections ,
{ 
public 
static 
void #
AddDependencyInjections 2
(2 3
this3 7
IServiceCollection8 J
servicesK S
)S T
{ 	!
AddScopedRepositories !
(! "
services" *
)* +
;+ ,
AddScopedServices 
( 
services &
)& '
;' ( 
AddScopedAppServices  
(  !
services! )
)) *
;* +
} 	
private 
static 
void !
AddScopedRepositories 1
(1 2
IServiceCollection2 D
servicesE M
)M N
{ 	
_ 
= 
services 
. 
	AddScoped "
<" #"
IProfileTypeRepository# 9
,9 :!
ProfileTypeRepository; P
>P Q
(Q R
)R S
;S T
_ 
= 
services 
. 
	AddScoped "
<" #&
IProfileTypeTaskRepository# =
,= >%
ProfileTypeTaskRepository? X
>X Y
(Y Z
)Z [
;[ \
_ 
= 
services 
. 
	AddScoped "
<" #
ITaskRepository# 2
,2 3
TaskRepository4 B
>B C
(C D
)D E
;E F
_ 
= 
services 
. 
	AddScoped "
<" #!
IUserSystemRepository# 8
,8 9 
UserSystemRepository: N
>N O
(O P
)P Q
;Q R
} 	
private 
static 
void 
AddScopedServices -
(- .
IServiceCollection. @
servicesA I
)I J
{ 	
_ 
= 
services 
. 
	AddScoped "
<" #
IProfileTypeService# 6
,6 7
ProfileTypeService8 J
>J K
(K L
)L M
;M N
_   
=   
services   
.   
	AddScoped   "
<  " ##
IProfileTypeTaskService  # :
,  : ;"
ProfileTypeTaskService  < R
>  R S
(  S T
)  T U
;  U V
_!! 
=!! 
services!! 
.!! 
	AddScoped!! "
<!!" #
ITaskService!!# /
,!!/ 0
TaskService!!1 <
>!!< =
(!!= >
)!!> ?
;!!? @
_"" 
="" 
services"" 
."" 
	AddScoped"" "
<""" #
IUserSystemService""# 5
,""5 6
UserSystemService""7 H
>""H I
(""I J
)""J K
;""K L
}## 	
private%% 
static%% 
void%%  
AddScopedAppServices%% 0
(%%0 1
IServiceCollection%%1 C
services%%D L
)%%L M
{&& 	
_'' 
='' 
services'' 
.'' 
	AddScoped'' "
<''" #
ITaskAppService''# 2
,''2 3
TaskAppService''4 B
>''B C
(''C D
)''D E
;''E F
_(( 
=(( 
services(( 
.(( 
	AddScoped(( "
<((" #!
IUserSystemAppService((# 8
,((8 9 
UserSystemAppService((: N
>((N O
(((O P
)((P Q
;((Q R
_)) 
=)) 
services)) 
.)) 
	AddScoped)) "
<))" #"
IProfileTypeAppService))# 9
,))9 :!
ProfileTypeAppService)); P
>))P Q
())Q R
)))R S
;))S T
}** 	
},, 
}-- 