# KDPasswordGenerator 生成金蝶用户密码加密字串
Kingdee K/3 wise Password Generator 
可用于此方法在自己开发的MIS系统中重置K3账套密码。
K/3 Wise 14.2.0 测试通过

除了网上公开的密码字符对照表外，还有以下特殊规则： 
1. 第7码对应第0列，第8码对应第9列...  
2. 第3/9/12..码是数字，前一码不是数字时，第3码改用第0列对照码 (0码开始) 
3. 第6/12/18..码是数字，前一码也是数字时，第6码改用第3列对照码 
4. 第3/6/9..码不是数字，前一码是数字时，删除上一个空格 

##使用
>string spid = KDPasswordEncry.EncryPassword(password);   
>if(spid!=""){  
>--执行SQL  update t_user set FSID=@spid,PasswordHashValue=null where FUserID=@userid   
>}  
>*注意14.0以上时，需同时清空PasswordHashValue栏位，否则登陆不了。*

BLOG: http://itjoy.net/362.html
