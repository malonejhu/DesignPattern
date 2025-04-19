using Composite.Example2;
using Composite.Practice1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractFile rootFloder = new Folder("我的資料");
            AbstractFile imageFolder = new Folder("圖片資料");
            AbstractFile txtFoloder = new Folder("文件資料");
            AbstractFile videoFolder = new Folder("影像資料");


            AbstractFile file1 = new ImageFile("小龍女.jpg");
            AbstractFile file2 = new ImageFile("張無忌.jpg");
            AbstractFile file3 = new TextFile("九陰真經.txt");
            AbstractFile file4 = new TextFile("葵花寶典.doc");
            AbstractFile file5 = new VideoFile("神鵰俠侶.rmb");


            imageFolder.Add(file1);
            imageFolder.Add(file2);

            txtFoloder.Add(file3);
            txtFoloder.Add(file4);

            videoFolder.Add(file5);

            rootFloder.Add(imageFolder);
            rootFloder.Add(txtFoloder);
            rootFloder.Add(videoFolder);

            rootFloder.KillVirus();
            //rootFloder.ShowName("");


            BaseSite rootSite = new Site("北京總部");


            BaseSite site1 = new Office("教務辦公室");
            BaseSite site2 = new Site("湖南分校");
            BaseSite site3 = new Office("行政辦公室");

            BaseSite site4 = new Office("教務辦公室");
            BaseSite site5 = new Site("長沙教學點");
            BaseSite site6 = new Site("湘潭教學點");
            BaseSite site7 = new Office("行政辦公室");

            BaseSite office1 = new Office("教務辦公室");
            BaseSite office2 = new Office("行政辦公室");

            BaseSite office3 = new Office("教務辦公室");
            BaseSite office4 = new Office("行政辦公室");



            rootSite.AddSite(site1);
            rootSite.AddSite(site2);
            rootSite.AddSite(site3);


            site2.AddSite(site4);
            site2.AddSite(site5);
            site2.AddSite(site6);
            site2.AddSite(site7);

            site5.AddSite(office1);
            site5.AddSite(office2);

            site6.AddSite(office3);
            site6.AddSite(office4);


            site2.Operation();

            Console.ReadLine();
        }
    }
}