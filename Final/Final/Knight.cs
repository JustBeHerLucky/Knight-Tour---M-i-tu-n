using System;
using System.Collections.Generic;
using System.Text;


namespace Final
{
 class Knight
    {
        //Khai báo biến
        public int kichThuoc;//Kích thước bàn cờ
        public int x, y;//Tọa độ xuất phát ban đầu x,y
        public int[,] dd = new int[2501, 2501];
        public int[,] kn = new int[2501, 2501];
        public int[,] vt = new int[3, 2501];
        public int[,] _vt = new int[3, 2501];//Tạm thời
        public int[,] run = new int[3, 9];
        public bool ngung = false;
        //Các phương thức
        public int getVT(int _i,int _j)
        {
            return vt[_i,_j];
        }
        public void Set(int _kichThuoc,int _X,int _Y) 
        {
            kichThuoc=_kichThuoc;
            x = _X;
            y = _Y;
        }
        //Kiểm tra khả năng đi
        public bool TimDuong()
        {
            khoiTao();
            dd[x, y] = 1; 
            xuly(1, x, y);
            if (ngung) return true;// cout << "\nKết Thúc.";
            else return false;// cout << "\nKhông có đường ";
        }
        public int kichThuockn(int i,int j)
        {
            int dem = 0;
            for(int l=1;l<=8;l++)
                if (i + run[1,l] >= 1 && i + run[1,l] <= kichThuoc && j + run[2,l] >= 1 && j + run[2,l] <= kichThuoc) dem++;
            return dem;
        }
        public void khoiTao()
        {
            //khoi tao
            for (int i = 1; i <= kichThuoc * kichThuoc; i++)
            {
                vt[1, i] = vt[2, i] = 0;
                _vt[1, i] = _vt[2, i] = 0;
            }
            for (int i = 1; i <= kichThuoc; i++)
                for (int j = 1; j <= kichThuoc; j++) dd[i,j] = 0;
            run[1,1] = -1; run[2,1] = -2;
            run[1,2] = 1; run[2,2] = -2;
            run[1,3] = -1; run[2,3] = 2;
            run[1,4] = 1; run[2,4] = 2;
            run[1,5] = -2; run[2,5] = -1;
            run[1,6] = -2; run[2,6] = 1;
            run[1,7] = 2; run[2,7] = -1;
            run[1,8] = 2; run[2,8] = 1;
            for (int i = 1; i <= kichThuoc; i++)
                for (int j = 1; j <= kichThuoc; j++) kn[i,j] = kichThuockn(i, j);
        }
        public int kiemtra()
        {
            for (int i = 1; i <= kichThuoc; i++)
                for (int j = 1; j <= kichThuoc; j++) if (dd[i,j] == 0) return 0;
            return 1;
        }
        public void xuly(int _i,int _x,int _y)
        {
            if(_i==kichThuoc*kichThuoc && ngung==false){
                ngung=true;
                if (kiemtra() == 1)
                {
                    for (int j = 1; j <= _i - 1; j++)
                    {
                        _vt[1, j] = vt[1, j];
                        _vt[2, j] = vt[2, j];
                    }
                }
            }
            else if(ngung==false){
                int[,] _run = new int[3, 9];
                int dem=0,i,j,l;
                //tim cac duong run tiep
                for( l=1;l<=8;l++)
                    if(_x+run[1,l]>=1 && _x+run[1,l]<=kichThuoc && _y+run[2,l]>=1 && _y+run[2,l]<=kichThuoc && dd[(_x+run[1,l]),(_y+run[2,l])]==0){
                        dem++;
                        _run[0,dem]=kn[ (_x+run[1,l]) ,(_y+run[2,l])];
                        _run[1,dem]=_x+run[1,l];
                        _run[2,dem]=_y+run[2,l];
                    }
                //sap xep theo kha nang
                int[] temp=new int[3];
                for( i=2;i<=dem;i++)
                    for( j=dem;j>=i;j--)
                    if(_run[0,j]<_run[0,j-1]){
                            temp[0]=_run[0,j];temp[1]=_run[1,j];temp[2]=_run[2,j];
                            _run[0,j]=_run[0,j-1];_run[1,j]=_run[1,j-1];_run[2,j]=_run[2,j-1];
                            _run[0,j-1]=temp[0];_run[1,j-1]=temp[1];_run[2,j-1]=temp[2];
                    }
                //Giam kha nang
                for(i=1;i<=dem;i++)
                    kn[(_run[1,i]),(_run[2,i])]--;
                kn[_x,_y]--;
                //bat dau duyet
                for(i=1;i<=dem;i++){
                    //danh dau
                    dd[(_run[1,i]),(_run[2,i])]=1;
                    //vi tri tiep theo
                    vt[1,_i]=_run[1,i];
                    vt[2,_i]=_run[2,i];
                    //goi xu ly cho vi tri tiep theo
                    xuly(_i+1,_run[1,i],_run[2,i]);
                    //bo danh dau
                    dd[(_run[1,i]),(_run[2,i])]=0;
                }
                //Tang lai kha nang
                for(i=1;i<=dem;i++)
                    kn[(_run[1,i]),(_run[2,i])]++;
                kn[_x,_y]++;
            }
        }
    }
    }
