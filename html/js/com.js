/*
=============================================================
函数名:GetCoolWeb(fdName)
变量:fdName当前操作的对象
作用:点击当前频道与显示对应的内容
=============================================================
*/
function GetPictureNews(fdName){
/*if (fdName.className=='buttonSelected') return;*/
//alert(fdName);
var OperObj=null
var FolderNameArray=new Array('ShowAd1','ShowAd2','ShowAd3')
var FolderAreaArray=new Array('ShowAdArea1','ShowAdArea2','ShowAdArea3')
fdName.className='buttonselected';
for (var i=0;i<FolderNameArray.length;i++)
{
OperObj=document.getElementById(FolderNameArray[i]);
//alert(OperObj);
AreaObj=document.getElementById(FolderAreaArray[i]);
if (OperObj!=null)
{
if(fdName==OperObj)
/*fdName.className='buttonSelected';*/
//{
AreaObj.style.display='';
//parent.frameOper.button1.value='保存设置'
//parent.frameOper.button2.disabled='disabled'
else
{
OperObj.className='buttondefault';
if(AreaObj!=null)AreaObj.style.display='none';
}
}
}
}
/*
=============================================================
函数名:GetCoolWeb(fdName)
变量:fdName当前操作的对象
作用:点击当前频道与显示对应的内容
=============================================================
*/
function GetBestBottom(fdName){
/*if (fdName.className=='buttonSelected') return;*/
var OperObj=null
var FolderNameArray=new Array('BestBottom1','BestBottom2','BestBottom3')
var FolderAreaArray=new Array('BestBottom1Area','BestBottom2Area','BestBottom3Area')
fdName.className='bestselected';
for (var i=0;i<FolderNameArray.length;i++)
{
OperObj=document.getElementById(FolderNameArray[i]);
AreaObj=document.getElementById(FolderAreaArray[i]);
if (OperObj!=null)
{
if(fdName==OperObj)
/*fdName.className='buttonSelected';*/
//{
AreaObj.style.display='';
//parent.frameOper.button1.value='保存设置'
//parent.frameOper.button2.disabled='disabled'
else
{
OperObj.className='bestdefault';
if(AreaObj!=null)AreaObj.style.display='none';
}
}
}
}
/*
=============================================================
函数名:GetFolder(fdName)
变量:fdName当前操作的对象
作用:点击当前频道与显示对应的内容
=============================================================
*/
function GetLogo(fdName){
/*if (fdName.className=='buttonSelected') return;*/
var OperObj=null
var FolderNameArray=new Array('Logo1','Logo2')
var FolderAreaArray=new Array('Logo1Area','Logo2Area')
fdName.className='buttonselected';
for (var i=0;i<FolderNameArray.length;i++)
{
OperObj=document.getElementById(FolderNameArray[i]);
AreaObj=document.getElementById(FolderAreaArray[i]);
if (OperObj!=null)
{
if(fdName==OperObj)
/*fdName.className='buttonSelected';*/
//{
AreaObj.style.display='';
//parent.frameOper.button1.value='保存设置'
//parent.frameOper.button2.disabled='disabled'
else
{
OperObj.className='buttondefault';
if(AreaObj!=null)AreaObj.style.display='none';
}
}
}
}