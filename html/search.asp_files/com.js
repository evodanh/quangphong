/*
=============================================================
������:GetCoolWeb(fdName)
����:fdName��ǰ�����Ķ���
����:�����ǰƵ������ʾ��Ӧ������
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
//parent.frameOper.button1.value='��������'
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
������:GetCoolWeb(fdName)
����:fdName��ǰ�����Ķ���
����:�����ǰƵ������ʾ��Ӧ������
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
//parent.frameOper.button1.value='��������'
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
������:GetFolder(fdName)
����:fdName��ǰ�����Ķ���
����:�����ǰƵ������ʾ��Ӧ������
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
//parent.frameOper.button1.value='��������'
//parent.frameOper.button2.disabled='disabled'
else
{
OperObj.className='buttondefault';
if(AreaObj!=null)AreaObj.style.display='none';
}
}
}
}