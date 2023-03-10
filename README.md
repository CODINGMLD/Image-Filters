# Image Filters Effect

<h2>Background</h2>

> In about 20 years of working with GDI, I never needed to do image filters. "If not now, when?" I decided to start with brightness and contrast. After a relatively extensive research, I came up with three reasonable approaches, and since I was already doing it, I decided to check the GetPixel / SetPixel speed – is it as slow as everyone claims?

<h2>Goals</h2>

1. To be open minded and persistent - even with great tools like AForge, you can often write a better, simpler, and faster solution yourself, with relatively little effort.
2. For more advanced members: it seems to me - for some strange reason, the unsafe mode is very popular. Very often, there is no need for it – you can accomplish the same with simple marshaling, or by other means.
3. Most important – translation of the QColorMatrix from C++ to C#. While doing this research – I did not see a better approach to image filtering, compared to the use of the QColorMatrix approach. This subject is very advanced; while the code itself is very simple and very readable, the math is relatively complicated. I can not explain the code unless I explain how the ColorMatrix works. But that is not the goal of this article. If your math level is strong enough, and you understand matrix multiplications and rotations, you can very easily understand and follow the code. If your math level is not strong enough, you can just use it as shown below - it works :).

![1](https://user-images.githubusercontent.com/65526236/224263868-ce4e3107-1f95-423e-87f5-5afb7738b019.PNG)

![2](https://user-images.githubusercontent.com/65526236/224263880-a514493f-72c5-486c-a559-4ad22a40d227.PNG)

![3](https://user-images.githubusercontent.com/65526236/224263894-aaa1848f-35da-401a-87fd-d175dfa9fc52.PNG)
