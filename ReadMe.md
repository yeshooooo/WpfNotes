# WPF个人学习笔记
### 参考教程
* 1.[b站朝夕教育](https://www.bilibili.com/video/BV1Ht4y1N7Dt?p=4&spm_id_from=pageDriver&vd_source=c6ca89f75d00cd4da634736edfcca1ae)
质量一般未看完
* 2.[刘铁锰提高](https://www.bilibili.com/video/BV1LW41197LV/?spm_id_from=333.337.search-card.all.click&vd_source=c6ca89f75d00cd4da634736edfcca1ae)  
 [刘铁锰入门](https://www.bilibili.com/video/BV1ht411e7Fe/?spm_id_from=333.337.search-card.all.click&vd_source=c6ca89f75d00cd4da634736edfcca1ae)  
 [刘铁锰B站个人空间](https://space.bilibili.com/7499477)



# tip
## 1 数据绑定
* this.控件名方式
* 在对应控件的构造函数中设置数据类 
```c#
this.DataContext = new MainViewModel();//MainViewModel 是保存数据的c#类
```
在标签中绑定属性

![File](file.png)
Value是MainViewModel中的属性

![File1](file1.png)
MainViewModel 必须实现INotifyPropertyChanged接口才能实现数据的双向绑定
![File3](file3.png)
这个事件不需要手动实现
但是触发改变的数据
![File2](file2.png)
需要广播 通知订阅者
### VM
![File33](file33.png)
![File30](file30.png)
类里写委托
![File36](file36.png)