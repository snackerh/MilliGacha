Imports System.IO
Imports System.Net
Imports System.Threading

Public Class Form1

    ' 통상 쓰알 105종
    Public ssrList() As String = {
        "[어서 오세요 우리의 극장에!] 아마미 하루카",
        "[시작되는 장소] 카스가 미라이",
        "[빛나는 별처럼] 모가미 시즈카",
        "[모두의 시선을 독점] 이부키 츠바사",
        "[꿈을 향해 내딛은 한걸음] 시라이시 츠무기",
        "[음악으로 자아내는 세계] 사쿠라모리 카오리",
        "[우아한 한 때] 시죠 타카네",
        "[팬시 드리밍] 하코자키 세리카",
        "[워터 드림] 미우라 아즈사",
        "[청려고아한 아가씨] 에밀리 스튜어트",
        "[반짝임에 몸을 맡기고] 미야오 미야",
        "[전해지는 마음] 가나하 히비키",
        "[샤이닝 월드] 줄리아",
        "[웃음을 꽃피우는 마칭] 야부키 카나",
        "[큐티 트릭♪] 미나세 이오리",
        "[달달한 숲에 어서오세요♪] 키노시타 히나타",
        "[눈부신 마드모아젤] 니카이도 치즈루",
        "[가을을 장식하는 엔터테이너] 후타미 아미",
        "[오늘도 기운 한 가득!] 나카타니 이쿠]",
        "[리틀 레이스 퀸] 오오가미 타마키",
        "[별이 내리는 성야] 하기와라 유키호",
        "[언제나 여름인 파라다이스!] 마이하마 아유무",
        "[드리미 플래닛] 타카야마 사요코",
        "[신춘의 빛에 소원을 담아] 키사라기 치하야",
        "[매혹의 엘레강트 타임] 시노미야 카렌",
        "[베이스볼 걸] 나가요시 스바루",
        "[신나는 스위트 타임] 후타미 마미",
        "[겨울에도 기운 한 가득!] 코사카 우미",
        "[상쾌한 바람에 이끌려] 키타카미 레이카",
        "[깜찍한 여자 아이] 스오 모모코",
        "[파워풀 걸] 후쿠다 노리코",
        "[반짝이는 뮤지엄] 아키즈키 리츠코",
        "[미소가 피는 계절] 시마바라 엘레나",
        "[이노센트 가든] 텐쿠바시 토모카",
        "[컬러풀 팩토리] 타카츠키 야요이",
        "[로맨틱 랜드] 토쿠가와 마츠리",
        "[해피☆파라!] 노노하라 아카네",
        "[사랑스러운 시선] 호시이 미키",
        "[로코나이즈 뮤직♪] 로코",
        "[두근거림을 밟으며 가자♪] 요코야마 나오",
        "[레이디 온 더 비치] 바바 코노미",
        "[사명을 다하는 자] 모치즈키 안나",
        "[트렌드를 선점♪] 토코로 메구미",
        "[마음에 드는 이야기] 나나오 유리코",
        "[선상의 테라피스트] 키타자와 시호",
        "[톡톡 튀는 여름의 맛♪] 사타케 미나코",
        "[초 비치발리볼 [킹]] 토요카와 후카",
        "[초 비치발리볼 [선배]] 타카야마 사요코",
        "[책의 세계에서 대모험!] 오오가미 타마키",
        "[꿈빛식부] 스오 모모코",
        "[세 자매 카페 [고양이]] 미야오 미야",
        "[세 자매 카페 [손님]] 모모세 리오",
        "[소악마 리빙 데드] 마츠다 아리사",
        "[애니멀 퍼레이드♪] 키노시타 히나타",
        "[극장 서스펜스 [탐정]] 시라이시 츠무기",
        "[극장 서스펜스 [지배인]] 마카베 미즈키",
        "[포춘 걸] 텐쿠바시 토모카",
        "[동경의 대변신] 코사카 우미",
        "[특별한 날을 위해] 로코",
        "[해피 홀리 나이트] 키타카미 레이카",
        "[환상의 빛 속에서] 니카이도 치즈루",
        "[프로즌 크리스털] 미우라 아즈사",
        "[뉴 이어 공] 후쿠다 노리코",
        "[풀 스로틀★걸] 카스가 미라이",
        "[스위트 팔레트 랜드] 나가요시 스바루",
        "[흰 학처럼] 바바 코노미",
        "[신나는♪ 히나마츠리] 후타미 아미",
        "[헤븐리 플라워즈] 토쿠가와 마츠리",
        "[블랙 스트랭스] 키쿠치 마코토",
        "[더 챌린저!] 후타미 마미",
        "[아늑한 차] 하기와라 유키호",
        "[미라클 퍼포머] 마이하마 아유무",
        "[두근거리는 순간] 시노미야 카렌",
        "[푹신푹신 드리밍] 아마미 하루카",
        "[아쿠아마린 머메이드] 키사라기 치하야",
        "[우정의 메타모르포제] 나카타니 이쿠",
        "[핫 서머 메모리즈] 가나하 히비키",
        "[깜찍한 요괴 고양이 딸] 노노하라 아카네",
        "[가을 향기에 휩싸여] 타나카 코토하",
        "[스포츠☆스마일] 타카츠키 야요이",
        "[동화 나라 이야기 [늑대]] 가나하 히비키",
        "[동화 나라 이야기 [여행자]] 나가요시 스바루",
        "[내가 좋아하는 것] 시죠 타카네",
        "[그레이트 하비스트] 타카야마 사요코",
        "[아웃사이더 [벨벳]] 키쿠치 마코토",
        "[아웃사이더 [파이널 데이]] 아마미 하루카",
        "[붉게 빛나며!] 요코야마 나오",
        "[이 시대를 즐기며] 사쿠라모리 카오리",
        "[성야를 장식하는 눈사람] 미야오 미야",
        "[스포트라이트 너머로] 아키즈키 리츠코",
        "[생각은 시가에 숨기고] 모가미 시즈카",
        "[반격의 헌터] 이부키 츠바사",
        "[주문] 야부키 카나",
        "[…In The Name Of。 …LOVE?] 마카베 미즈키",
        "[이머전시 이머전스] 로코",
        "[Be My Boy] 모모세 리오",
        "[오렌지색 하늘 아래] 토요카와 후카",
        "[염소씨와 집배원] 에밀리 스튜어트",
        "[VIVID 이매지네이션] 모치즈키 안나",
        "[스마일 최고] 사타케 미나코",
        "[외딴 섬 서스펜스 호러 [저택 주인]] 니카이도 치즈루",
        "[외딴 섬 서스펜스 호러 [메이드]] 키타자와 시호",
        "[가끔은 시소] 나카타니 이쿠",
        "[프라이빗 로드쇼] 미나세 이오리",
        "[칠흑의 저격수] 줄리아"
    }

    ' 페스 쓰알 23종
    Dim fesList() As String = {
        "[도시의 바람을 받으며] 시라이시 츠무기",
        "[윈터 스노 매직] 사쿠라모리 카오리",
        "[반짝반짝 콘체르토] 하코자키 세리카",
        "[늠름하게, 화려하게] 에밀리 스튜어트",
        "[순진한 레이니 데이즈] 카스가 미라이",
        "[물방울 프리즘] 모가미 시즈카",
        "[비 갠 뒤의 약속] 이부키 츠바사",
        "[가을빛 하이, 터치♪] 타카츠키 야요이",
        "[월광 판타지아] 미나세 이오리",
        "[리얼 인텐션] 키타자와 시호",
        "[인조이♡윈터 데이트] 야부키 카나",
        "[스태리 글로우] 호시이 미키",
        "[선샤인 브라이트] 가나하 히비키",
        "[달처럼 빛나는] 시죠 타카네",
        "[어제도 오늘도 그 다음에도…] 타나카 코토하",
        "[베스트 샷 모멘트!] 토코로 메구미",
        "[스마일 에브리데이♡] 시마바라 엘레나",
        "[맛있게 드세요…♡] 스오 모모코",
        "[쪽! 해버릴 거야♪] 나카타니 이쿠",
        "[행복은 라지 사이즈로] 나나오 유리코",
        "[크리스마스 미션] 모치즈키 안나",
        "[연결되는 미소] 아마미 하루카",
        "[그 앞의 빛에] 시노미야 카렌"
    }

    ' 쓰알 픽업
    Dim ssrPickup() As String = {
        "[엘리건트 링] 시죠 타카네",
        "[축복에 둘러싸여] 시마바라 엘레나"
    }

    ' 스알 픽업
    Dim srPickup() As String = {
        "[수줍은 웃음의 나데시코] 에밀리 스튜어트",
        "[교복 시리즈] 마이하마 아유무"
        }

    Dim allCardList As List(Of String) = New List(Of String)

    Dim ssrChance As Double = 3.0
    Dim srChance As Double = 12.0

    Dim ssrpickupChance As Double = 0.33
    Dim srpickupChance As Double = 0.2

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each item As String In ssrPickup
            PickupSelect.Items.Add(item)
        Next
        For Each item As String In srPickup
            PickupSelect.Items.Add(item)
        Next
    End Sub

    Private Sub NormalMode_CheckedChanged(sender As Object, e As EventArgs)
        If allCardList.Count > 0 Then
            allCardList.Clear()
            PickupSelect.Items.Clear()
        End If
        For Each item As String In ssrList
            allCardList.Add(item)
            Result.Items.Add(item)
        Next
        For Each item As String In ssrPickup
            allCardList.Add(item)
            Result.Items.Add(item)
            PickupSelect.Items.Add(item)
        Next
        For Each item As String In srPickup
            Result.Items.Add(item)
            PickupSelect.Items.Add(item)
        Next
    End Sub

    Private Sub FesMode_CheckedChanged(sender As Object, e As EventArgs)
        ssrChance = 6.0

        If allCardList.Count > 0 Then
            allCardList.Clear()
            PickupSelect.Items.Clear()
        End If
        For Each item As String In ssrList
            allCardList.Add(item)
            Result.Items.Add(item)
        Next
        For Each item As String In fesList
            allCardList.Add(item)
            Result.Items.Add(item)
        Next
        For Each item As String In srPickup
            Result.Items.Add(item)
            PickupSelect.Items.Add(item)
        Next
    End Sub

    Private Sub onetime_Click(sender As Object, e As EventArgs) Handles onetime.Click
        gacha(1)
    End Sub

    Private Sub gacha(times As Integer)
        If times <= 0 Then
            MsgBox("0 이하의 숫자는 입력할 수 없습니다!")
            Exit Sub
        End If
        Result.Items.Clear()

        Dim ssrcount As Integer = 0
        Dim srcount As Integer = 0

        Dim rnd As Random = New Random
        For index As Integer = 1 To times
            Dim gacharesult As Double = rnd.Next(0, 10001) / 100
            If gacharesult <= ssrChance Then
                If gacharesult <= 0.99 Then
                    Result.Items.Add("픽업SSR★" + ssrPickup.ElementAt(Int(rnd.Next(0, ssrPickup.Length()))))
                    Result.SetSelected(Result.Items.Count() - 1, True)
                Else
                    Result.Items.Add("SSR☆" + ssrList.ElementAt(Int(rnd.Next(0, ssrList.Length()))))
                End If
                ssrcount = ssrcount + 1
            Else
                If (index Mod 10 = 0) Then
                    If gacharesult <= (1 - ssrChance) * srpickupChance Then
                        gacharesult = Int(rnd.Next(0, srPickup.Length()))
                        Result.Items.Add("픽업SR◇" + srPickup.ElementAt(gacharesult))
                    Else
                        Result.Items.Add("금나비")
                    End If
                    srcount = srcount + 1
                ElseIf gacharesult <= ssrChance + srChance Then
                    If gacharesult <= ssrChance + srChance * srpickupChance Then
                        gacharesult = Int(rnd.Next(0, srPickup.Length()))
                        Result.Items.Add("픽업SR◇" + srPickup.ElementAt(gacharesult))
                    Else
                        Result.Items.Add("금나비")
                    End If
                    srcount = srcount + 1
                Else
                    Result.Items.Add("은나비")
                End If
            End If
        Next

        Result.Items.Add("")
        Result.Items.Add("가챠 종료!")
        Result.Items.Add("결과: SSR " + ssrcount.ToString + "장, SR " + srcount.ToString + "장")
        Result.SetSelected(Result.Items.Count() - 1, True)


    End Sub

    Private Sub snipe(isComplete As Boolean, isCeiling As Boolean)

        Dim snipelist As List(Of String) = New List(Of String)

        If isComplete Then
            For index As Integer = 0 To PickupSelect.Items.Count - 1
                snipelist.Add(PickupSelect.Items(index).ToString)
            Next
        Else
            For index As Integer = 0 To PickupSelect.Items.Count - 1
                If PickupSelect.GetItemChecked(index) = True Then
                    snipelist.Add(PickupSelect.Items(index).ToString)
                End If
            Next

            If snipelist.Count = 0 Then
                Return
            End If
        End If

        Result.Items.Clear()

        Dim count As Integer = 0
        Dim ssrcount As Integer = 0
        Dim srcount As Integer = 0
        Dim rnd As Random = New Random

        Do While True
            count = count + 1
            If count Mod 300 = 0 And isCeiling Then
                Result.Items.Add("!천장!" + snipelist.ElementAt(0))
                Result.SetSelected(Result.Items.Count() - 1, True)
                snipelist.RemoveAt(0)
            Else
                Dim gacharesult As Double = rnd.Next(0, 10001) / 100
                If gacharesult <= ssrChance Then
                    If gacharesult <= ssrChance * ssrpickupChance Then
                        gacharesult = Int(rnd.Next(0, ssrPickup.Length()))
                        Result.Items.Add("픽업SSR★" + ssrPickup.ElementAt(gacharesult))
                        Result.SetSelected(Result.Items.Count() - 1, True)
                        If snipelist.Contains(ssrPickup.ElementAt(gacharesult)) Then
                            snipelist.Remove(ssrPickup.ElementAt(gacharesult))
                        End If
                    Else
                        gacharesult = Int(rnd.Next(0, ssrList.Length()))
                        Result.Items.Add("SSR☆" + ssrList.ElementAt(Int(rnd.Next(0, ssrList.Length()))))
                    End If
                    ssrcount = ssrcount + 1
                Else
                    If (count Mod 10 = 0) Then
                        If gacharesult <= (1 - ssrChance) * srpickupChance Then
                            gacharesult = Int(rnd.Next(0, srPickup.Length()))
                            Result.Items.Add("픽업SR◇" + srPickup.ElementAt(gacharesult))
                            Result.SetSelected(Result.Items.Count() - 1, True)
                            If snipelist.Contains(srPickup.ElementAt(gacharesult)) Then
                                snipelist.Remove(srPickup.ElementAt(gacharesult))
                            End If
                        Else
                            Result.Items.Add("금나비")
                        End If
                        srcount = srcount + 1
                    ElseIf gacharesult <= ssrChance + srChance Then
                        If gacharesult <= ssrChance + srChance * srpickupChance Then
                            gacharesult = Int(rnd.Next(0, srPickup.Length()))
                            Result.Items.Add("픽업SR◇" + srPickup.ElementAt(gacharesult))
                            Result.SetSelected(Result.Items.Count() - 1, True)
                            If snipelist.Contains(srPickup.ElementAt(gacharesult)) Then
                                snipelist.Remove(srPickup.ElementAt(gacharesult))
                            End If
                        Else
                            Result.Items.Add("금나비")
                        End If
                        srcount = srcount + 1
                    Else
                        Result.Items.Add("은나비")
                    End If
                End If
            End If
            Thread.Sleep(30)

            If snipelist.Count = 0 Then
                Result.Items.Add("")
                Result.Items.Add("저격 종료!")
                Result.Items.Add("결과: " + count.ToString + "회 중 SSR " + ssrcount.ToString + "장, SR " + srcount.ToString + "장")
                Result.SetSelected(Result.Items.Count() - 1, True)
                Return
            End If
        Loop

    End Sub

    Private Sub tentimes_Click(sender As Object, e As EventArgs) Handles tentimes.Click
        gacha(10)
    End Sub

    Private Sub customtry_Click(sender As Object, e As EventArgs) Handles customtry.Click
        Dim trynum
        trynum = InputBox("시행 횟수는?",, "10",,)
        If IsNumeric(trynum) Then
            gacha(Integer.Parse(trynum))
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        snipe(False, True)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        snipe(True, True)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        snipe(True, False)
    End Sub
End Class