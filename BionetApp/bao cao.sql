select dd.MaBenhNhan,dd.TenChiCuc, dd.TenDVCS,-- (case when sum(dd.isNguyCoCao)>1 then 1 else sum(dd.isNguyCoCao) end) isBNNguyCo,
						 --dd.IDPhieu, dd.MaChiCuc, dd.MaDVCS, dd.isDaDuyetKQ, dd.MaPhieu, dd.NgayTiepNhan,dd.MaPhieuCu, dd.MaGoiXN, dd.TenGoiDichVuChung, 
						-- dd.isNguyCoCao, dd.isXoa, dd.MaDichVu,  dd.IDKyThuat,
						--dd.IDThongSoXN,
						sum( dd.G6PD_L1)G6PD_L1,(case when sum(dd.isNguyCo_G6PD_L1)>1 then 1 else sum(dd.isNguyCo_G6PD_L1) end) isNguyCo_G6PD_L1,
						sum( dd.CH_L1)CH_L1, (case when sum(dd.isNguyCo_CH_L1)>1 then 1 else sum(dd.isNguyCo_CH_L1) end) isNguyCo_CH_L1,
						sum(dd.CAH_L1)CAH_L1 , (case when sum(dd.isNguyCo_CAH_L1)>1 then 1 else sum(dd.isNguyCo_CAH_L1) end) isNguyCo_CAH_L1,
						sum(dd.GAL_L1)GAL_L1 , (case when sum(dd.isNguyCo_GAL_L1)>1 then 1 else sum(dd.isNguyCo_GAL_L1) end) isNguyCo_GAL_L1,
						sum(dd.PKU_L1)PKU_L1 , (case when sum(dd.isNguyCo_PKU_L1)>1 then 1 else sum(dd.isNguyCo_PKU_L1) end) isNguyCo_PKU_L1,
						sum(dd.G6PD_L2)G6PD_L2 , (case when sum(dd.isNguyCo_G6PD_L2)>1 then 1 else sum(dd.isNguyCo_G6PD_L2) end) isNguyCo_G6PD_L2,
						sum(dd.CH_L2)CH_L2, (case when sum(dd.isNguyCo_CH_L2)>1 then 1 else sum(dd.isNguyCo_CH_L2) end) isNguyCo_CH_L2,
						sum(dd.CAH_L2)CAH_L2 , (case when sum(dd.isNguyCo_CAH_L2)>1 then 1 else sum(dd.isNguyCo_CAH_L2) end) isNguyCo_CAH_L2,
						sum(dd.GAL_L2)GAL_L2 , (case when sum(dd.isNguyCo_GAL_L2)>1 then 1 else sum(dd.isNguyCo_GAL_L2) end) isNguyCo_GAL_L2,
						sum(dd.PKU_L2)PKU_L2 , (case when sum(dd.isNguyCo_PKU_L2)>1 then 1 else sum(dd.isNguyCo_PKU_L2) end) isNguyCo_PKU_L2
						
						
 from
 (
 SELECT p.MaBenhNhan,
				 cc.TenChiCuc, cs.TenDVCS,kq.isNguyCoCao,
						--  ph.IDPhieu, cc.MaChiCuc, cs.MaDVCS,
						--   kq.isDaDuyetKQ, kq.MaPhieu, kq.NgayTiepNhan, 
						--isnull(kq.MaPhieuCu,0)MaPhieuCu, kq.MaGoiXN, gdv.TenGoiDichVuChung,  kq.isXoa, kqct.MaDichVu,  kqct.IDKyThuat,
						--kqct.IDThongSoXN,
						 (case when kq.MaGoiXN != 'DVGXN0001'  then isnull(CONVERT(numeric(5,2),kqct.GiaTriCuoi),0) else 0 end) as G6PD_L1,
						  (case when kq.MaGoiXN != 'DVGXN0001'  then kqct.isNguyCo else 0 end) as isNguyCo_G6PD_L1,
						  (case when kq.MaGoiXN = 'DVGXN0001'  then isnull(CONVERT(numeric(5,2),kqct.GiaTriCuoi),0) else 0 end) as G6PD_L2, 
						  (case when kq.MaGoiXN = 'DVGXN0001'  then kqct.isNguyCo else 0 end) as isNguyCo_G6PD_L2,
						   0 CH_L1, 0 isNguyCo_CH_L1,0 CH_L2, 0 isNguyCo_CH_L2,
						 0 CAH_L1, 0 isNguyCo_CAH_L1,0 CAH_L2, 0 isNguyCo_CAH_L2,
						 0 GAL_L1, 0 isNguyCo_GAL_L1,0 GAL_L2, 0 isNguyCo_GAL_L2
						 ,0 PKU_L1,0 isNguyCo_PKU_L1 ,0 PKU_L2, 0 isNguyCo_PKU_L2
		FROM            dbo.PSXN_TraKetQua AS kq INNER JOIN
                         dbo.PSXN_TraKQ_ChiTiet AS kqct ON kq.MaPhieu = kqct.MaPhieu AND kq.MaTiepNhan = kq.MaTiepNhan INNER JOIN
                         dbo.PSPhieuSangLoc AS ph ON ph.IDPhieu = kq.MaPhieu INNER JOIN
                         dbo.PSPatient p ON ph.MaBenhNhan = p.MaBenhNhan INNER JOIN     dbo.PSDanhMucDonViCoSo cs on ph.IDCoSo = cs.MaDVCS INNER JOIN
                         dbo.PSDanhMucChiCuc  cc  on cs.MaChiCuc = cc.MaChiCuc INNER JOIN dbo.PSDanhMucGoiDichVuChung gdv on kq.MaGoiXN =gdv.IDGoiDichVuChung
						 where kq.isXoa =0 and kq.isDaDuyetKQ =1 and ph.TrangThaiMau >3 AND kqct.IDThongSoXN ='G6PD'
						-- order by MaBenhNhan
						 UNION all
SELECT p.MaBenhNhan,
					  cc.TenChiCuc, cs.TenDVCS,kq.isNguyCoCao,
						--  ph.IDPhieu, cc.MaChiCuc, cs.MaDVCS,
						--   kq.isDaDuyetKQ, kq.MaPhieu, kq.NgayTiepNhan, 
						--isnull(kq.MaPhieuCu,0)MaPhieuCu, kq.MaGoiXN, gdv.TenGoiDichVuChung,  kq.isXoa, kqct.MaDichVu,  kqct.IDKyThuat,
						--kqct.IDThongSoXN,
						 0 G6PD_L1, 0 isNguyCo_G6PD_L1,0 G6PD_L2, 0 isNguyCo_G6PD_L2,
						 (case when kq.MaGoiXN != 'DVGXN0001'  then isnull(CONVERT(numeric(5,2),kqct.GiaTriCuoi),0) else 0 end) as CH_L1,
						  (case when kq.MaGoiXN != 'DVGXN0001'  then kqct.isNguyCo else 0 end) as isNguyCo_CH_L1,
						  (case when kq.MaGoiXN = 'DVGXN0001'  then isnull(CONVERT(numeric(5,2),kqct.GiaTriCuoi),0) else 0 end) as CH_L2, 
						  (case when kq.MaGoiXN = 'DVGXN0001'  then kqct.isNguyCo else 0 end) as isNguyCo_CH_L2, 
						 0 CAH_L1, 0 isNguyCo_CAH_L1,0 CAH_L2, 0 isNguyCo_CAH_L2,
						 0 GAL_L1, 0 isNguyCo_GAL_L1,0 GAL_L2, 0 isNguyCo_GAL_L2
						,0 PKU_L1,0 isNguyCo_PKU_L1,0 PKU_L2, 0 isNguyCo_PKU_L2
		FROM            dbo.PSXN_TraKetQua AS kq INNER JOIN
                         dbo.PSXN_TraKQ_ChiTiet AS kqct ON kq.MaPhieu = kqct.MaPhieu AND kq.MaTiepNhan = kq.MaTiepNhan INNER JOIN
                         dbo.PSPhieuSangLoc AS ph ON ph.IDPhieu = kq.MaPhieu INNER JOIN
                         dbo.PSPatient p ON ph.MaBenhNhan = p.MaBenhNhan INNER JOIN     dbo.PSDanhMucDonViCoSo cs on ph.IDCoSo = cs.MaDVCS INNER JOIN
                         dbo.PSDanhMucChiCuc  cc  on cs.MaChiCuc = cc.MaChiCuc INNER JOIN dbo.PSDanhMucGoiDichVuChung gdv on kq.MaGoiXN =gdv.IDGoiDichVuChung
						 where kq.isXoa =0 and kq.isDaDuyetKQ =1 and ph.TrangThaiMau >3 AND kqct.IDThongSoXN ='CH'
					--	 order by MaBenhNhan
						 UNION all

	 SELECT p.MaBenhNhan,
					  cc.TenChiCuc, cs.TenDVCS,kq.isNguyCoCao,
						--  ph.IDPhieu, cc.MaChiCuc, cs.MaDVCS,
						--   kq.isDaDuyetKQ, kq.MaPhieu, kq.NgayTiepNhan, 
						--isnull(kq.MaPhieuCu,0)MaPhieuCu, kq.MaGoiXN, gdv.TenGoiDichVuChung,  kq.isXoa, kqct.MaDichVu,  kqct.IDKyThuat,
						--kqct.IDThongSoXN,
						 0 G6PD_L1, 0 isNguyCo_G6PD_L1,0 G6PD_L2, 0 isNguyCo_G6PD_L2,
						 0 CH_L1, 0 isNguyCo_CH_L1, 0 CH_L2,0  isNguyCo_CH_L2, 
						(case when kq.MaGoiXN != 'DVGXN0001'  then isnull(CONVERT(numeric(5,2),kqct.GiaTriCuoi),0) else 0 end) as  CAH_L1,
						 (case when kq.MaGoiXN != 'DVGXN0001'  then kqct.isNguyCo else 0 end) as isNguyCo_CAH_L1,
						(case when kq.MaGoiXN = 'DVGXN0001'  then isnull(CONVERT(numeric(5,2),kqct.GiaTriCuoi),0) else 0 end) as CAH_L2, 
						 (case when kq.MaGoiXN = 'DVGXN0001'  then kqct.isNguyCo else 0 end) as isNguyCo_CAH_L2,
						 0 GAL_L1, 0 isNguyCo_GAL_L1,0 GAL_L2, 0 isNguyCo_GAL_L2
						 ,0 PKU_L1,0 isNguyCo_PKU_L1,0 PKU_L2, 0 isNguyCo_PKU_L2
		FROM            dbo.PSXN_TraKetQua AS kq INNER JOIN
                         dbo.PSXN_TraKQ_ChiTiet AS kqct ON kq.MaPhieu = kqct.MaPhieu AND kq.MaTiepNhan = kq.MaTiepNhan INNER JOIN
                         dbo.PSPhieuSangLoc AS ph ON ph.IDPhieu = kq.MaPhieu INNER JOIN
                         dbo.PSPatient p ON ph.MaBenhNhan = p.MaBenhNhan INNER JOIN     dbo.PSDanhMucDonViCoSo cs on ph.IDCoSo = cs.MaDVCS INNER JOIN
                         dbo.PSDanhMucChiCuc  cc  on cs.MaChiCuc = cc.MaChiCuc INNER JOIN dbo.PSDanhMucGoiDichVuChung gdv on kq.MaGoiXN =gdv.IDGoiDichVuChung
						 where kq.isXoa =0 and kq.isDaDuyetKQ =1 and ph.TrangThaiMau >3 AND kqct.IDThongSoXN ='CAH'
						-- order by MaBenhNhan
						 UNION all

				SELECT p.MaBenhNhan,
					 cc.TenChiCuc, cs.TenDVCS,kq.isNguyCoCao,
						--  ph.IDPhieu, cc.MaChiCuc, cs.MaDVCS,
						--   kq.isDaDuyetKQ, kq.MaPhieu, kq.NgayTiepNhan, 
						--isnull(kq.MaPhieuCu,0)MaPhieuCu, kq.MaGoiXN, gdv.TenGoiDichVuChung,  kq.isXoa, kqct.MaDichVu,  kqct.IDKyThuat,
						--kqct.IDThongSoXN,
						  0 G6PD_L1, 0 isNguyCo_G6PD_L1,0 G6PD_L2, 0 isNguyCo_G6PD_L2, 
						  0 CH_L1, 0 isNguyCo_CH_L1,0 CH_L2, 0 isNguyCo_CH_L2,
						 0 CAH_L1, 0 isNguyCo_CAH_L1,0 CAH_L2, 0 isNguyCo_CAH_L2,
						0 GAL_L1, 0 isNguyCo_GAL_L1,0 GAL_L2, 0 isNguyCo_GAL_L2
						 ,(case when kq.MaGoiXN != 'DVGXN0001'  then isnull(CONVERT(numeric(5,2),kqct.GiaTriCuoi),0) else 0 end) as PKU_L1,(case when kq.MaGoiXN != 'DVGXN0001'  then kqct.isNguyCo else 0 end) as isNguyCo_PKU_L1
						 ,(case when kq.MaGoiXN = 'DVGXN0001'  then isnull(CONVERT(numeric(5,2),kqct.GiaTriCuoi),0) else 0 end) as PKU_L2, (case when kq.MaGoiXN = 'DVGXN0001'  then kqct.isNguyCo else 0 end) as isNguyCo_PKU_L2
						 
		FROM            dbo.PSXN_TraKetQua AS kq INNER JOIN
                         dbo.PSXN_TraKQ_ChiTiet AS kqct ON kq.MaPhieu = kqct.MaPhieu AND kq.MaTiepNhan = kq.MaTiepNhan INNER JOIN
                         dbo.PSPhieuSangLoc AS ph ON ph.IDPhieu = kq.MaPhieu INNER JOIN
                         dbo.PSPatient p ON ph.MaBenhNhan = p.MaBenhNhan INNER JOIN     dbo.PSDanhMucDonViCoSo cs on ph.IDCoSo = cs.MaDVCS INNER JOIN
                         dbo.PSDanhMucChiCuc  cc  on cs.MaChiCuc = cc.MaChiCuc INNER JOIN dbo.PSDanhMucGoiDichVuChung gdv on kq.MaGoiXN =gdv.IDGoiDichVuChung
						 where kq.isXoa =0 and kq.isDaDuyetKQ =1 and ph.TrangThaiMau >3 AND kqct.IDThongSoXN ='PKU'
					
						 UNION all
	SELECT p.MaBenhNhan,
						  cc.TenChiCuc, cs.TenDVCS,kq.isNguyCoCao,
						--  ph.IDPhieu, cc.MaChiCuc, cs.MaDVCS,
						--   kq.isDaDuyetKQ, kq.MaPhieu, kq.NgayTiepNhan, 
						--isnull(kq.MaPhieuCu,0)MaPhieuCu, kq.MaGoiXN, gdv.TenGoiDichVuChung,  kq.isXoa, kqct.MaDichVu,  kqct.IDKyThuat,
						--kqct.IDThongSoXN,
						  0 G6PD_L1, 0 isNguyCo_G6PD_L1,0 G6PD_L2, 0 isNguyCo_G6PD_L2, 
						  0 CH_L1, 0 isNguyCo_CH_L1,0 CH_L2, 0 isNguyCo_CH_L2,
						 0 CAH_L1, 0 isNguyCo_CAH_L1,0 CAH_L2, 0 isNguyCo_CAH_L2,
						(case when kq.MaGoiXN != 'DVGXN0001'  then isnull(CONVERT(numeric(5,2),kqct.GiaTriCuoi),0) else 0 end) as  GAL_L1, 
						(case when kq.MaGoiXN != 'DVGXN0001'  then kqct.isNguyCo else 0 end) as isNguyCo_GAL_L1,
						(case when kq.MaGoiXN = 'DVGXN0001'  then isnull(CONVERT(numeric(5,2),kqct.GiaTriCuoi),0) else 0 end) as GAL_L2, 
						(case when kq.MaGoiXN = 'DVGXN0001'  then kqct.isNguyCo else 0 end) as isNguyCo_GAL_L2
						 ,0 PKU_L1, 0 isNguyCo_PKU_L1,0 PKU_L2, 0 isNguyCo_PKU_L2
						 
		FROM            dbo.PSXN_TraKetQua AS kq INNER JOIN
                         dbo.PSXN_TraKQ_ChiTiet AS kqct ON kq.MaPhieu = kqct.MaPhieu AND kq.MaTiepNhan = kq.MaTiepNhan INNER JOIN
                         dbo.PSPhieuSangLoc AS ph ON ph.IDPhieu = kq.MaPhieu INNER JOIN
                         dbo.PSPatient p ON ph.MaBenhNhan = p.MaBenhNhan INNER JOIN     dbo.PSDanhMucDonViCoSo cs on ph.IDCoSo = cs.MaDVCS INNER JOIN
                         dbo.PSDanhMucChiCuc  cc  on cs.MaChiCuc = cc.MaChiCuc INNER JOIN dbo.PSDanhMucGoiDichVuChung gdv on kq.MaGoiXN =gdv.IDGoiDichVuChung
						 where kq.isXoa =0 and kq.isDaDuyetKQ =1 and ph.TrangThaiMau >3 AND kqct.IDThongSoXN ='GAL'
						
						 
) dd
						 group by dd.MaBenhNhan
						 ,dd.TenChiCuc, dd.TenDVCS--, dd.isNguyCoCao
						 --, dd.IDPhieu, dd.MaChiCuc, dd.MaDVCS, dd.isDaDuyetKQ, dd.MaPhieu, dd.NgayTiepNhan, 
						--dd.MaPhieuCu, dd.MaGoiXN, dd.TenGoiDichVuChung, dd.isXoa, dd.MaDichVu,  dd.IDKyThuat
						--,dd.IDThongSoXN
						--,dd.G6PD_L1, dd.isNguyCo_G6PD_L1,dd.G6PD_L2, dd.isNguyCo_G6PD_L2, 
						--  dd.CH_L1,dd.isNguyCo_CH_L1,dd.CH_L2, dd.isNguyCo_CH_L2
						-- , dd.CAH_L1,dd.isNguyCo_CAH_L1,dd.CAH_L2, dd.isNguyCo_CAH_L2,
						-- dd.GAL_L1, dd.isNguyCo_GAL_L1,dd.GAL_L2,dd.isNguyCo_GAL_L2,
						--dd.PKU_L1,dd.isNguyCo_PKU_L1 ,dd.PKU_L2, dd.isNguyCo_PKU_L2
