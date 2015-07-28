using System;

namespace DesignPatterns.Builder.KFC
{
    /// <summary>
    /// Builder�࣬�����������࣬�����ײ�
    /// </summary>
    public abstract class Builder
    {
        /// <summary>
        /// ��Ӻ���
        /// </summary>
        public abstract void BuildHamb();

        /// <summary>
        /// ��ӿ���
        /// </summary>
        public abstract void BuildCoke();

        /// <summary>
        /// �������
        /// </summary>
        public abstract void BuildChip();

        /// <summary>
        /// ���ؽ��
        /// </summary>
        /// <returns>ʳƷ����</returns>
        public abstract Food GetFood();
    }
}
